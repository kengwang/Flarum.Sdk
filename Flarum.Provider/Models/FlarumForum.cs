using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Flarum.Provider.Models
{
    public class FlarumForum
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string BaseUrl { get; set; }
        public string BasePath { get; set; }
        public string BaseOrigin { get; set; }
        public string ApiUrl { get; set; }
        public string LogoUrl { get; set; }
        public string FaviconUrl { get; set; }
        public string GuidelinesUrl { get; set; }
        public string AssetsBaseUrl { get; set; }
        public string WelcomeTitle { get; set; }
        public string WelcomeMessage { get; set; }
        public string HeaderHtml { get; set; }
        public string FooterHtml { get; set; }
        public string MinPrimaryTags { get; set; }
        public string MaxPrimaryTags { get; set; }
        public string MinSecondaryTags { get; set; }
        public string MaxSecondaryTags { get; set; }
        public string PusherKey { get; set; }
        public string PusherCluster { get; set; }
        // Forum Theme.
        public string PrimaryColor { get; set; }
        public string SecondaryColor { get; set; }
        // Forum configs.
        public bool ShowLanguageSelector { get; set; }
        public bool AllowSignUp { get; set; }
        public bool CanViewForum { get; set; }
        public bool CanStartDiscussion { get; set; }
        public bool CanSearchUser { get; set; }
        public bool CanCreateAccessToken { get; set; }
        public bool CanModerateAccessTokens { get; set; }
        public bool CanViewFlags { get; set; }
        public bool AllowUsernameMentionFormat { get; set; }
        public bool CanBypassTagCounts { get; set; }
    }
}
