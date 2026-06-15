using System.Text.Json;
using Azure.Identity;
using ProgressTracker;
using ProgressTracker.Models;
using ProgressTracker.Models.ConfigOptions;
using ProgressTracker.Storage;

var builder = WebApplication.CreateBuilder(args);

IConfiguration AzureConfigurations = builder.Configuration.GetSection("AzureStorage");

string AzureKVName = AzureConfigurations.GetValue<string>("KeyVaultName")
    ?? throw new Exception("KeyVaultName is not configured in AzureStorage section.");

string AzureKeyVaultURI = $"https://{AzureKVName}.vault.azure.net/";

builder.Configuration.AddAzureKeyVault(new Uri(AzureKeyVaultURI), new DefaultAzureCredential());

ICollection<string> allowedOrigins = builder.Configuration.GetSection("originEndpoints").Get<List<string>>()
                            ?? [];

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
        policy.WithOrigins([.. allowedOrigins])
              .AllowAnyHeader()
              .AllowAnyMethod());
});

builder.Services.ConfigureHttpJsonOptions(opts =>
{
    opts.SerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
    opts.SerializerOptions.WriteIndented = true;
});

builder.Services.Configure<AzureStorageOptions>(AzureConfigurations);

builder.Services.AddSingleton<IBlobPlansRepository, BlobPlansRepository>();
builder.Services.AddSingleton<ITableProgressRepository, TableProgressRepository>();

var app = builder.Build();
app.UseCors();

// GET /api/plans — list all plan IDs from blob storage
app.MapGet("/api/plans", async (IBlobPlansRepository planRepo) =>
{
    var plans = await planRepo.ListPlansAsync();
    return Results.Ok(plans);
});

// GET /api/plans/{planId} — return parsed plan as structured JSON
app.MapGet("/api/plans/{planId}", async (string planId, IBlobPlansRepository planRepo) =>
{
    var content = await planRepo.GetPlanContentAsync(planId);
    if (content is null)
        return Results.NotFound($"Plan '{planId}' not found.");

    var plan = PlanParser.Parse(planId, content);
    return Results.Ok(plan);
});

// GET /api/plans/{planId}/progress — return saved progress
app.MapGet("/api/plans/{planId}/progress", async (string planId, ITableProgressRepository progressRepo) =>
{
    var progress = await progressRepo.GetProgressAsync(planId);
    return Results.Ok(progress);
});

// POST /api/plans/{planId}/progress — save progress
app.MapPost("/api/plans/{planId}/progress", async (string planId, HttpRequest request, ITableProgressRepository progressRepo) =>
{
    using var reader = new StreamReader(request.Body);
    var json = await reader.ReadToEndAsync();

    var progress = JsonSerializer.Deserialize<ProgressModel>(json, new JsonSerializerOptions
    {
        PropertyNameCaseInsensitive = true
    }) ?? new ProgressModel();

    await progressRepo.SaveProgressAsync(planId, progress);
    return Results.Ok(new { saved = true });
});

app.Run();

