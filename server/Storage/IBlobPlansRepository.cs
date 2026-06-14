namespace ProgressTracker.Storage;

public interface IBlobPlansRepository
{
    Task<IReadOnlyList<string>> ListPlansAsync(CancellationToken cancellationToken = default);
    Task<string?> GetPlanContentAsync(string planId, CancellationToken cancellationToken = default);
}
