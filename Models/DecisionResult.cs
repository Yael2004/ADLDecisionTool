namespace ADLDecisionTool.Models;

public class DecisionResult
{
    public List<Recommendation> Recommendations { get; set; } = new();

    public DecisionSummary Summary { get; set; } = new();
}