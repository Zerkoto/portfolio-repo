namespace BlazorApp.Models;

public sealed class SiteProperties
{
    public string Name { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string HeroEyebrow { get; set; } = string.Empty;
    public string HeroSummary { get; set; } = string.Empty;
    public string ProfileImage { get; set; } = string.Empty;
    public string ProfileImageAlt { get; set; } = string.Empty;
    public List<string> ProofPoints { get; set; } = new();
    public string PrimaryCtaLabel { get; set; } = string.Empty;
    public string PrimaryCtaHref { get; set; } = string.Empty;
    public string SecondaryCtaLabel { get; set; } = string.Empty;
    public string SecondaryCtaHref { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string GitHub { get; set; } = string.Empty;
    public string LinkedIn { get; set; } = string.Empty;
}
