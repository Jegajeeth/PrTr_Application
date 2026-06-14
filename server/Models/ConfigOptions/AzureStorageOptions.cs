namespace ProgressTracker.Models.ConfigOptions;

public record AzureStorageOptions
{
    public string ConnectionString { get; set; } = string.Empty;
    public string PlansBlobContainer { get; set; } = string.Empty;
    public string ProgressTable { get; set; } = string.Empty;
}
