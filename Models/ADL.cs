namespace ADLDecisionTool.Models;

public class ADL
{
    public string Name { get; set; } = string.Empty;

    public List<string> SystemTypes { get; set; } = new();

    public List<string> Domains { get; set; } = new();

    public List<string> Characteristics { get; set; } = new();

    public List<string> Benefits { get; set; } = new();

    public List<string> Limitations { get; set; } = new();

    public List<string> Tools { get; set; } = new();
}