namespace BlazorApp.Models;

public sealed class AboutMe
{
    public string Introduction { get; set; } = string.Empty;
    public string Evidence { get; set; } = string.Empty;
    public List<AboutHighlight> Highlights { get; set; } = new();
    public List<FocusArea> FocusAreas { get; set; } = new();
}

public sealed class AboutHighlight
{
    public string Text { get; set; } = string.Empty;
    public string Icon { get; set; } = "education";
    public string Url { get; set; } = string.Empty;
}
