namespace ADLDecisionTool.Models;

public class DecisionViewModel
{
    public string? SystemType { get; set; }

    public string? Domain { get; set; }

    public List<string> Characteristics { get; set; } = new();

    public List<string> AvailableSystemTypes { get; set; } = new();

    public List<string> AvailableDomains { get; set; } = new();

    public List<Characteristic> AvailableCharacteristics { get; set; } = new();

    public List<Recommendation> Recommendations { get; set; } = new();

    public DecisionSummary? Summary { get; set; }
}