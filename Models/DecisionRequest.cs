namespace ADLDecisionTool.Models;

public class DecisionRequest
{
    public string? SystemType { get; set; }

    public string? Domain { get; set; }

    public List<string> Characteristics { get; set; } = new();
}