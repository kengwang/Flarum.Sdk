using Flarum.Api.Bases.ModelBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Flarum.Api.Models.ResponseModel
{
    public class FlarumUserDto : FlarumModelBase
    {
        [JsonPropertyName("username")] public string Username { get; set; }
        [JsonPropertyName("displayName")] public string DisplayName { get; set; }
        [JsonPropertyName("avatarUrl")] public string AvatarUrl { get; set; }
        [JsonPropertyName("slug")] public string Slug { get; set; }
        [JsonPropertyName("joinTime")] public DateTime JoinTime { get; set; }
        [JsonPropertyName("discussionCount")] public int DiscussionACount { get; set; }
        [JsonPropertyName("commentCount")] public int CommentCount { get; set; }
        [JsonPropertyName("canEdit")] public bool CanEdit { get; set; }
        [JsonPropertyName("canEditCredentials")] public bool CanEditCredentials { get; set; }
        [JsonPropertyName("canEditGroups")] public bool CanEditGroups { get; set; }
        [JsonPropertyName("canDelete")] public bool CanDelete { get; set; }
        [JsonPropertyName("lastSeenAt")] public DateTime LastSeenAt { get; set; }
        [JsonPropertyName("nearataTwoFactorCanEnable")] public bool NearataTwoFactorCanEnable { get; set; }
        [JsonPropertyName("canSuspend")] public bool CanSuspend { get; set; }
        [JsonPropertyName("canEditNickname")] public bool CanEditNickname { get; set; }
        [JsonPropertyName("canSpamblock")] public bool CanSpamblock { get; set; }
        [JsonPropertyName("blocksPd")] public bool BlocksPd { get; set; }
        [JsonPropertyName("cannotBeDirectMessaged")] public bool CannotBeDirectMessaged { get; set; }
        [JsonPropertyName("points")] public int Points { get; set; }
        [JsonPropertyName("canHaveVotingNotifications")] public bool CanHaveVotingNotifications { get; set; }
        [JsonPropertyName("canMiserable")] public bool CanMiserable { get; set; }
        [JsonPropertyName("canBeFollowed")] public bool CanBeFollowed { get; set; }
        [JsonPropertyName("followingCount")] public int FollowingCount { get; set; }
        [JsonPropertyName("followerCount")] public int FollowerCount { get; set; }
        [JsonPropertyName("bio")] public string Bio { get; set; }
        [JsonPropertyName("canViewBio")] public bool CanViewBio { get; set; }
        [JsonPropertyName("canEditBio")] public bool CanEditBio { get; set; }
        [JsonPropertyName("canViewSocialProfile")] public bool CanViewSocialProfile { get; set; }
        [JsonPropertyName("canEditSocialProfile")] public bool CanEditSocialProfile { get; set; }
        [JsonPropertyName("canEditPolls")] public bool CanEditPolls { get; set; }
        [JsonPropertyName("canStartPolls")] public bool CanStartPolls { get; set; }
        [JsonPropertyName("canSelfEditPolls")] public bool CanSelfEditPolls { get; set; }
        [JsonPropertyName("canVotePolls")] public bool CanVotePolls { get; set; }
        [JsonPropertyName("ignored")] public bool Ignored { get; set; }
        [JsonPropertyName("canBeIgnored")] public bool CanBeIgnored { get; set; }
        [JsonPropertyName("bestAnswerCount")] public int BestAnswerCount { get; set; }
        [JsonPropertyName("canViewWarnings")] public bool CanViewWarnings { get; set; }
        [JsonPropertyName("canManageWarnings")] public bool CanManageWarnings { get; set; }
        [JsonPropertyName("canDeleteWarnings")] public bool CanDeleteWarnings { get; set; }
        [JsonPropertyName("visibleWarningCount")] public int VisibleWarningCount { get; set; }
    }
}
