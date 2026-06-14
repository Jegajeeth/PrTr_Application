using ProgressTracker.Models;

namespace ProgressTracker.Storage;

public interface ITableProgressRepository
{
    Task<ProgressModel> GetProgressAsync(string planId, CancellationToken cancellationToken = default);
    Task SaveProgressAsync(string planId, ProgressModel progress, CancellationToken cancellationToken = default);
}
