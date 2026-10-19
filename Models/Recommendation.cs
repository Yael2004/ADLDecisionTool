namespace ADLDecisionTool.Models;

public class Recommendation
{
    public ADL ADL { get; set; } = new();

    public double Score { get; set; }

    public List<string> MatchingCharacteristics { get; set; } = new();

    public bool IsIntersection { get; set; }
}