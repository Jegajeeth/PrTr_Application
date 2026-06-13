namespace ProgressTracker.Models;

/// <summary>
/// Progress keyed by phaseId → set of completed topic IDs, plus whether the phase itself is marked complete.
/// </summary>
public class ProgressModel
{
    public Dictionary<string, PhaseProgress> Phases { get; set; } = new();
}

public class PhaseProgress
{
    public bool PhaseComplete { get; set; } = false;
    public HashSet<string> CompletedTopics { get; set; } = new();
}
