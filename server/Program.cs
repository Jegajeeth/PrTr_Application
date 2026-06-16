using System.Text.Json;
using Azure.Identity;
using Microsoft.Azure.Functions.Worker.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProgressTracker.Models.ConfigOptions;
using ProgressTracker.Storage;

var builder = FunctionsApplication.CreateBuilder(args);
builder.ConfigureFunctionsWebApplication();

string AzureKVName = builder.Configuration.GetValue<string>("KeyVaultName")
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

builder.Services.Configure<AzureStorageOptions>(builder.Configuration.GetSection("AzureStorage"));

builder.Services.AddSingleton<IBlobPlansRepository, BlobPlansRepository>();
builder.Services.AddSingleton<ITableProgressRepository, TableProgressRepository>();

await builder.Build().RunAsync();

