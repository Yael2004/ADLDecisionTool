namespace ADLDecisionTool.Models;

public class DecisionSummary
{
    public string Rule { get; set; } = string.Empty;

    public string RuleDescription { get; set; } = string.Empty;

    public int CandidateCount { get; set; }

    public int SelectedCharacteristicsCount { get; set; }

    public int TypeCandidateCount { get; set; }

    public int DomainCandidateCount { get; set; }

    public int IntersectionCount { get; set; }

    public string? SystemType { get; set; }

    public string? Domain { get; set; }
}