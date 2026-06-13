using System.Text.Json;
using ProgressTracker;
using ProgressTracker.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
        policy.WithOrigins("http://localhost:5173")
              .AllowAnyHeader()
              .AllowAnyMethod());
});

builder.Services.ConfigureHttpJsonOptions(opts =>
{
    opts.SerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
    opts.SerializerOptions.WriteIndented = true;
});

var app = builder.Build();
app.UseCors();

// Resolve the plans directory relative to the project root (two levels up from build output)
var plansRoot = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "..", "plans"));

// GET /api/plans — list all task folder names
app.MapGet("/api/plans", () =>
{
    if (!Directory.Exists(plansRoot))
        return Results.Problem($"Plans folder not found at: {plansRoot}");

    var plans = Directory.GetDirectories(plansRoot)
        .Select(Path.GetFileName)
        .Where(name => name is not null)
        .ToList();

    return Results.Ok(plans);
});

// GET /api/plans/{planId} — return parsed plan as structured JSON
app.MapGet("/api/plans/{planId}", (string planId) =>
{
    var planFile = Path.Combine(plansRoot, planId, "plan.md");
    if (!File.Exists(planFile))
        return Results.NotFound($"Plan '{planId}' not found.");

    var content = File.ReadAllText(planFile);
    var plan = PlanParser.Parse(planId, content);
    return Results.Ok(plan);
});

// GET /api/plans/{planId}/progress — return saved progress
app.MapGet("/api/plans/{planId}/progress", (string planId) =>
{
    var progressFile = Path.Combine(plansRoot, planId, "progress.json");
    if (!File.Exists(progressFile))
        return Results.Ok(new ProgressModel());

    var json = File.ReadAllText(progressFile);
    var progress = JsonSerializer.Deserialize<ProgressModel>(json, new JsonSerializerOptions
    {
        PropertyNameCaseInsensitive = true
    }) ?? new ProgressModel();

    return Results.Ok(progress);
});

// POST /api/plans/{planId}/progress — save progress
app.MapPost("/api/plans/{planId}/progress", async (string planId, HttpRequest request) =>
{
    var planDir = Path.Combine(plansRoot, planId);
    if (!Directory.Exists(planDir))
        return Results.NotFound($"Plan '{planId}' not found.");

    using var reader = new StreamReader(request.Body);
    var json = await reader.ReadToEndAsync();

    var progressFile = Path.Combine(planDir, "progress.json");
    await File.WriteAllTextAsync(progressFile, json);

    return Results.Ok(new { saved = true });
});

app.Run();
