using System.Net.Http.Json;
using BlazorApp.Models;

namespace BlazorApp.Services;

public sealed class PortfolioContentService(HttpClient client)
{
    private Task<SiteProperties?>? _siteProperties;
    private Task<AboutMe?>? _aboutMe;
    private Task<List<ExperienceHighlight>?>? _experience;
    private Task<SocialIcons?>? _socialIcons;

    public Task<SiteProperties?> GetSitePropertiesAsync() =>
        _siteProperties ??= client.GetFromJsonAsync<SiteProperties>("sample-data/siteproperties.json");

    public Task<AboutMe?> GetAboutMeAsync() =>
        _aboutMe ??= client.GetFromJsonAsync<AboutMe>("sample-data/aboutme.json");

    public Task<List<ExperienceHighlight>?> GetExperienceAsync() =>
        _experience ??= client.GetFromJsonAsync<List<ExperienceHighlight>>("sample-data/experience.json");

    public Task<SocialIcons?> GetSocialIconsAsync() =>
        _socialIcons ??= client.GetFromJsonAsync<SocialIcons>("sample-data/socialicons.json");
}
