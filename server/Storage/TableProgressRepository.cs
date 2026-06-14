using System.Text.Json;
using Azure;
using Azure.Data.Tables;
using Microsoft.Extensions.Options;
using ProgressTracker.Models;
using ProgressTracker.Models.ConfigOptions;

namespace ProgressTracker.Storage;

public class TableProgressRepository : ITableProgressRepository
{
    private readonly TableClient _tableClient;

    private static readonly JsonSerializerOptions JsonOptions = new()
    {
        PropertyNameCaseInsensitive = true
    };

    public TableProgressRepository(IOptions<AzureStorageOptions> options)
    {
        AzureStorageOptions? configuration = options.Value;
        string? connectionString = configuration.ConnectionString
            ?? throw new InvalidOperationException("AzureStorage:ConnectionString is not configured.");
        string? tableName = configuration.ProgressTable ?? "PlanProgress";

        var serviceClient = new TableServiceClient(connectionString);
        _tableClient = serviceClient.GetTableClient(tableName);
        _tableClient.CreateIfNotExists();
    }

    public async Task<ProgressModel> GetProgressAsync(string planId, CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await _tableClient.GetEntityAsync<TableEntity>(planId, "progress", cancellationToken: cancellationToken);
            var json = response.Value.GetString("JsonData");

            if (string.IsNullOrWhiteSpace(json))
                return new ProgressModel();

            return JsonSerializer.Deserialize<ProgressModel>(json, JsonOptions) ?? new ProgressModel();
        }
        catch (RequestFailedException ex) when (ex.Status == 404)
        {
            return new ProgressModel();
        }
    }

    public async Task SaveProgressAsync(string planId, ProgressModel progress, CancellationToken cancellationToken = default)
    {
        var json = JsonSerializer.Serialize(progress, JsonOptions);

        var entity = new TableEntity(planId, "progress")
        {
            ["JsonData"] = json
        };

        await _tableClient.UpsertEntityAsync(entity, TableUpdateMode.Replace, cancellationToken);
    }
}

public interface IProgressRepository
{
}