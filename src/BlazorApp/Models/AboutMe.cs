namespace BlazorApp.Models;

public sealed class AboutMe
{
    public string Introduction { get; set; } = string.Empty;
    public string Evidence { get; set; } = string.Empty;
    public List<FocusArea> FocusAreas { get; set; } = new();
}
