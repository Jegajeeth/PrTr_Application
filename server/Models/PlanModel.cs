namespace ProgressTracker.Models;

public record Topic(string Id, string Text);

public record Phase(
    string Id,
    string Title,
    string Weeks,
    string Goal,
    List<Topic> Topics,
    string Certification,
    string Capstone,
    string Notes,
    string Difficulty = "",
    string Prerequisites = "",
    string TimeCommitment = "",
    List<string>? ArchitectSkills = null,
    string SmallProject = "",
    string MediumProject = "",
    string AmbitiousProject = "",
    List<string>? Resources = null
);

public record Plan(string Id, string Title, List<Phase> Phases);
