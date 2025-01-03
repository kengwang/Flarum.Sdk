using Flarum.Api.Models.ResponseModel;
using Flarum.Provider.Models;
using System;

namespace Flarum.Provider.Mappers
{
    public class ForumDataToFlarumForumMapper
    {
        public static FlarumForum MapToFlarumForum(FlarumForumDto data)
        {
            return new FlarumForum
            {
                Title = data.Title,
                WelcomeTitle = data.WelcomeTitle,
                BaseUrl = data.BaseUrl,
                BasePath = data.BasePath,
                BaseOrigin = data.BaseOrigin,
                ApiUrl = data.ApiUrl,
                LogoUrl = data.LogoUrl,
                FaviconUrl = data.FaviconUrl,
                GuidelinesUrl = data.GuidelinesUrl,
                AssetsBaseUrl = data.AssetsBaseUrl,
                Description = data.Description,
                WelcomeMessage = data.WelcomeMessage,
                HeaderHtml = data.HeaderHtml,
                FooterHtml = data.FooterHtml,
                MinPrimaryTags = data.MinPrimaryTags,
                MaxPrimaryTags = data.MaxPrimaryTags,
                MinSecondaryTags = data.MinSecondaryTags,
                MaxSecondaryTags = data.MaxSecondaryTags,
                PusherKey = data.PusherKey,
                PusherCluster = data.PusherCluster,
                PrimaryColor = data.PrimaryColor,
                SecondaryColor = data.SecondaryColor,
                ShowLanguageSelector = data.ShowLanguageSelector,
                AllowSignUp = data.AllowSignUp,
                CanViewForum = data.CanViewForum,
                CanStartDiscussion = data.CanStartDiscussion,
                CanSearchUser = data.CanSearchUser,
                CanCreateAccessToken = data.CanCreateAccessToken,
                CanModerateAccessTokens = data.CanModerateAccessTokens,
                CanViewFlags = data.CanViewFlags,
                AllowUsernameMentionFormat = data.AllowUsernameMentionFormat,
                CanBypassTagCounts = data.CanBypassTagCounts

            };
        }
    }
}