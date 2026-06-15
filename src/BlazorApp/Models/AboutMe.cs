namespace BlazorApp.Models;

public sealed class AboutMe
{
    public string Introduction { get; set; } = string.Empty;
    public string Evidence { get; set; } = string.Empty;
    public List<string> Highlights { get; set; } = new();
    public List<FocusArea> FocusAreas { get; set; } = new();
}
