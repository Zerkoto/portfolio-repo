namespace BlazorApp.Models;

public sealed class SkillGroup
{
    public string Title { get; set; } = string.Empty;
    public string Icon { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public List<string> Skills { get; set; } = new();
}
