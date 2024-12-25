using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Flarum.Api.Bases.ModelBases;

namespace Flarum.Api.Models.ResponseModel
{
    public class FlarumForumDto : FlarumModelBase
    {
        // Forum basic informations.
        [JsonPropertyName("title")] public string Title { get; set; }
        [JsonPropertyName("description")] public string Description { get; set; }
        [JsonPropertyName("baseUrl")] public string BaseUrl { get; set; }
        [JsonPropertyName("basePath")] public string BasePath { get; set; }
        [JsonPropertyName("baseOrigin")] public string BaseOrigin { get; set; }
        [JsonPropertyName("apiUrl")] public string ApiUrl { get; set; }
        [JsonPropertyName("logoUrl")] public string LogoUrl { get; set; }
        [JsonPropertyName("FaviconUrl")] public string FaviconUrl { get; set; }
        [JsonPropertyName("guidelinesUrl")] public string GuidelinesUrl { get; set; }
        [JsonPropertyName("assetsBaseUrl")] public string AssetsBaseUrl { get; set; }
        [JsonPropertyName("welcomeTitle")] public string WelcomeTitle { get; set; }
        [JsonPropertyName("welcomeMeassage")] public string WelcomeMessage { get; set; }
        [JsonPropertyName("headerHtml")] public string HeaderHtml { get; set; }
        [JsonPropertyName("footerHtml")] public string FooterHtml { get; set; }
        [JsonPropertyName("minPrimaryTags")] public string MinPrimaryTags { get; set; }
        [JsonPropertyName("maxPrimaryTags")] public string MaxPrimaryTags { get; set; }
        [JsonPropertyName("minSecondaryTags")] public string MinSecondaryTags { get; set; }
        [JsonPropertyName("maxSecondaryTags")] public string MaxSecondaryTags { get; set; }
        [JsonPropertyName("pusherKey")] public string PusherKey { get; set; }
        [JsonPropertyName("pusherCluster")] public string PusherCluster { get; set; }
        // Forum Theme.
        [JsonPropertyName("themePrimaryColor")] public string PrimaryColor { get; set; }
        [JsonPropertyName("themeSecondaryColor")] public string SecondaryColor { get; set; }
        // Forum configs.
        [JsonPropertyName("showLanguageSelector")] public bool ShowLanguageSelector { get; set; }
        [JsonPropertyName("allowSignUp")] public bool AllowSignUp { get; set; }
        [JsonPropertyName("canViewForum")] public bool CanViewForum { get; set; }
        [JsonPropertyName("canStartDiscussion")] public bool CanStartDiscussion { get; set; }
        [JsonPropertyName("canSearchUser")] public bool CanSearchUser { get; set; }
        [JsonPropertyName("canCreateAccessToken")] public bool CanCreateAccessToken { get; set; }
        [JsonPropertyName("canModerateAccessTokens")] public bool CanModerateAccessTokens { get; set; }
        [JsonPropertyName("canViewFlags")] public bool CanViewFlags { get; set; }
        [JsonPropertyName("allowUsernameMentionFormat")] public bool AllowUsernameMentionFormat { get; set; }
        [JsonPropertyName("canBypassTagCounts")] public bool CanBypassTagCounts { get; set; }
    }
}
