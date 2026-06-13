using System.Text.RegularExpressions;
using ProgressTracker.Models;

namespace ProgressTracker;

public static class PlanParser
{
    // Matches the LAST (…) group on the line as weeks — handles titles like
    // "Infrastructure as Code (IaC) & Automation (Weeks 15–18)"
    private static readonly Regex PhaseHeaderRegex = new(
        @"PHASE\s+(\d+):\s*(.+)\s+\(([^)]+)\)\s*$",
        RegexOptions.IgnoreCase | RegexOptions.Compiled
    );

    public static Plan Parse(string planId, string content)
    {
        var lines = content.Split('\n').Select(l => l.TrimEnd()).ToArray();

        var title = lines
            .SkipWhile(l => string.IsNullOrWhiteSpace(l) || l.StartsWith("=") || l.StartsWith("-"))
            .FirstOrDefault(l => !string.IsNullOrWhiteSpace(l) && !l.StartsWith("=") && !l.StartsWith("-"))
            ?? planId;

        var phases = new List<Phase>();

        var phaseStartIndices = new List<(int LineIndex, Match Match)>();
        for (int i = 0; i < lines.Length; i++)
        {
            var m = PhaseHeaderRegex.Match(lines[i]);
            if (m.Success)
                phaseStartIndices.Add((i, m));
        }

        for (int p = 0; p < phaseStartIndices.Count; p++)
        {
            var (startLine, match) = phaseStartIndices[p];
            int endLine = p + 1 < phaseStartIndices.Count
                ? phaseStartIndices[p + 1].LineIndex
                : lines.Length;

            var phaseLines = lines[startLine..endLine];

            var phaseNumber = match.Groups[1].Value;
            var phaseTitle = match.Groups[2].Value.Trim();
            var weeks = match.Groups[3].Value.Trim();
            var phaseId = $"phase-{phaseNumber}";

            var goal = ExtractSection(phaseLines, "Goal:");
            var topics = ExtractBullets(phaseLines, "Key Topics:");
            var certification = ExtractSection(phaseLines, "Target Certification:");
            var capstone = ExtractSection(phaseLines, "Capstone Project:");
            var notes = ExtractSection(phaseLines, "Notes:");

            var difficulty = ExtractSection(phaseLines, "Difficulty:");
            var prerequisites = ExtractSection(phaseLines, "Prerequisites:");
            var timeCommitment = ExtractSection(phaseLines, "Time Commitment:");
            var architectSkills = ExtractBullets(phaseLines, "Architect Skills:");
            var smallProject = ExtractSection(phaseLines, "Small Project:");
            var mediumProject = ExtractSection(phaseLines, "Medium Project:");
            var ambitiousProject = ExtractSection(phaseLines, "Ambitious Project:");
            var resources = ExtractBullets(phaseLines, "Resources:");

            var topicModels = topics
                .Select((text, idx) => new Topic($"topic-{idx}", text))
                .ToList();

            phases.Add(new Phase(
                phaseId, phaseTitle, weeks, goal, topicModels,
                certification, capstone, notes,
                difficulty, prerequisites, timeCommitment,
                architectSkills, smallProject, mediumProject, ambitiousProject,
                resources));
        }

        return new Plan(planId, title, phases);
    }

    private static string ExtractSection(string[] lines, string sectionHeader)
    {
        var result = new List<string>();
        bool inSection = false;

        foreach (var line in lines)
        {
            if (line.TrimStart().StartsWith(sectionHeader, StringComparison.OrdinalIgnoreCase))
            {
                inSection = true;
                var inline = line.Substring(line.IndexOf(':') + 1).Trim();
                if (!string.IsNullOrWhiteSpace(inline))
                    result.Add(inline);
                continue;
            }

            if (!inSection) continue;
            if (IsNewSection(line)) break;

            var trimmed = line.TrimStart();
            if (string.IsNullOrWhiteSpace(trimmed) || trimmed.StartsWith("=")) continue;

            // Accept bullet lines (strip leading "- ") and plain continuation lines
            if (trimmed.StartsWith("- "))
                result.Add(trimmed[2..].Trim());
            else if (!trimmed.StartsWith("-"))
                result.Add(trimmed);
        }

        return string.Join(" ", result).Trim();
    }

    private static List<string> ExtractBullets(string[] lines, string sectionHeader)
    {
        var bullets = new List<string>();
        bool inSection = false;

        foreach (var line in lines)
        {
            if (line.TrimStart().StartsWith(sectionHeader, StringComparison.OrdinalIgnoreCase))
            {
                inSection = true;
                continue;
            }

            if (!inSection) continue;
            if (IsNewSection(line)) break;

            var trimmed = line.TrimStart();
            if (trimmed.StartsWith("- "))
                bullets.Add(trimmed[2..].Trim());
        }

        return bullets;
    }

    private static bool IsNewSection(string line)
    {
        var known = new[]
        {
            "Goal:", "Key Topics:", "Target Certification:", "Capstone Project:", "Notes:",
            "Difficulty:", "Prerequisites:", "Time Commitment:", "Architect Skills:",
            "Small Project:", "Medium Project:", "Ambitious Project:", "Resources:"
        };
        return known.Any(s => line.TrimStart().StartsWith(s, StringComparison.OrdinalIgnoreCase))
               || line.StartsWith("---")
               || line.StartsWith("===");
    }
}

