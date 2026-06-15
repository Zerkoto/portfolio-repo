namespace BlazorApp.Models;

public sealed class FocusArea
{
    public string Title { get; set; } = string.Empty;
    public string Icon { get; set; } = string.Empty;
    public string Tagline { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public List<string> Bullets { get; set; } = new();
}
