using Flarum.Api.Bases.ModelBases;
using System.Text.Json.Serialization;

namespace Flarum.Api.Models.ResponseModel
{
    public class FlarumDiscussionDto : FlarumModelBase
    {
        [JsonPropertyName("title")] public string Title { get; set; }
        [JsonPropertyName("slug")] public string Slug { get; set; }
        [JsonPropertyName("subscription")] public string Subscription { get; set; }
        [JsonPropertyName("commentCount")] public int CommentCount { get; set; }
        [JsonPropertyName("participantCount")] public int ParticipantCount { get; set; }
        [JsonPropertyName("replyTemplate")] public string ReplyTemplate { get; set; }
        [JsonPropertyName("lastPostNumber")] public int LastPostNumber { get; set; }
        [JsonPropertyName("lastReadPostNumber")] public int LastReadPostNumber { get; set; }
        [JsonPropertyName("votes")] public string Votes { get; set; }
        [JsonPropertyName("createdAt")] public DateTime CreatedAt { get; set; }
        [JsonPropertyName("lastPostedAt")] public DateTime LastPostedAt { get; set; }
        [JsonPropertyName("lastReadAt")] public DateTime LastReadAt { get; set; }
        [JsonPropertyName("bestAnswerSetAt")] public DateTime? BestAnswerSetAt { get; set; }
        [JsonPropertyName("frontDate")] public DateTime? FrontDate { get; set;}
        [JsonPropertyName("canReply")] public bool CanReply { get; set; }
        [JsonPropertyName("canRename")] public bool CanRename { get; set; }
        [JsonPropertyName("canDelete")] public bool CanDelete { get; set; }
        [JsonPropertyName("canHide")] public bool CanHide { get; set; }
        [JsonPropertyName("isApproved")] public bool IsApproved { get; set; }
        [JsonPropertyName("hasApproved")] public bool HasApproved { get; set; }
        [JsonPropertyName("hasUpvoted")] public bool HasUpvoted { get; set; }
        [JsonPropertyName("hasDownvoted")] public bool HasDownvoted { get; set; }
        [JsonPropertyName("canTag")] public bool CanTag {  get; set; }
        [JsonPropertyName("canEditRecipients")] public bool CanEditRecipients { get; set; }
        [JsonPropertyName("canEditUserRecipients")] public bool CanEditUserRecipients { get; set; }
        [JsonPropertyName("canEditGroupRecipients")] public bool CanEditGroupRecipients { get; set; }
        [JsonPropertyName("isPrivateDiscussion")]  public bool IsPrivateDiscusion { get; set; }
        [JsonPropertyName("canSeeReactions")] public bool CanSeeReactions { get; set; }
        [JsonPropertyName("isLocked")] public bool IsLocked { get; set; }
        [JsonPropertyName("canLock")] public bool CanLock { get; set; }
        [JsonPropertyName("canSplit")] public bool CanSplit { get; set; }
        [JsonPropertyName("canMerge")] public bool CanMerge { get; set; }
        [JsonPropertyName("front")] public bool Front {  get; set; }
        [JsonPropertyName("canSelectBestAnswer")] public bool CanSelectBestAnswer { get; set; }
        [JsonPropertyName("isSticky")] public bool IsSticky { get; set; }
        [JsonPropertyName("canViewWhoTypes")] public bool CanViewWhoTypes { get; set; }
        [JsonPropertyName("canMarkUnread")] public bool CanMarkUnread { get; set; }
        [JsonPropertyName("canManageReplyTemplates")] public bool  CanManageReplyTemplates { get; set; }
    }
}
