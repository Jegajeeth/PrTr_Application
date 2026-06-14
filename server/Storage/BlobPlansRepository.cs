using Azure;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Microsoft.Extensions.Options;
using ProgressTracker.Models.ConfigOptions;

namespace ProgressTracker.Storage;

public class BlobPlansRepository : IBlobPlansRepository
{
    private readonly BlobContainerClient _container;

    public BlobPlansRepository(IOptions<AzureStorageOptions> options)
    {
        var connectionString = options.Value.ConnectionString;
        var containerName = options.Value.PlansBlobContainer;

        if (string.IsNullOrWhiteSpace(connectionString))
            throw new ArgumentException("Azure Storage connection string is not configured.");

        if (string.IsNullOrWhiteSpace(containerName))
            throw new ArgumentException("Azure Storage blob container name is not configured.");

        _container = new BlobContainerClient(connectionString, containerName);
    }

    public async Task<IReadOnlyList<string>> ListPlansAsync(CancellationToken cancellationToken = default)
    {
        List<string>? plans = [];

        // Each plan is a virtual folder: {planId}/plan.md
        // List blobs with a delimiter to enumerate virtual directories.

        AsyncPageable<BlobHierarchyItem> BlobItems = _container.GetBlobsByHierarchyAsync(
            traits: BlobTraits.None,
            states: BlobStates.None,
            delimiter: "/",
            prefix: null,
            cancellationToken: cancellationToken);

        await foreach (BlobHierarchyItem page in BlobItems)
        {
            if (page.IsPrefix)
            {
                // Prefix is "{planId}/" — strip the trailing slash
                string? planId = page.Prefix.TrimEnd('/');
                if (!string.IsNullOrWhiteSpace(planId))
                    plans.Add(planId);
            }
        }

        return plans;
    }

    public async Task<string?> GetPlanContentAsync(string planId, CancellationToken cancellationToken = default)
    {
        var blobClient = _container.GetBlobClient($"{planId}/plan.md");

        if (!await blobClient.ExistsAsync(cancellationToken))
            return null;

        var response = await blobClient.DownloadContentAsync(cancellationToken);
        return response.Value.Content.ToString();
    }
}
