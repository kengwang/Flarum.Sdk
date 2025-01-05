using Flarum.Api.Models.ResponseModel;
using Flarum.Provider.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flarum.Provider.Mappers
{
    public class DiscussionDataToFlarumDiscussionMapper
    {
        public static FlarumDiscussion MapToFlarumDiscussion(FlarumDiscussionDto data)
        {
            return new FlarumDiscussion
            {
                Title = data.Title,
                Slug = data.Slug,
                Subscription = data.Subscription,
                CommentCount = data.CommentCount,
                ParticipantCount = data.ParticipantCount,
                ReplyTemplate = data.ReplyTemplate,
                LastPostNumber = data.LastPostNumber,
                Votes = data.Votes,
                CreatedAt = data.CreatedAt,
                LastPostedAt = data.LastPostedAt,
                LastReadAt = data.LastReadAt,
                BestAnswerSetAt = data.BestAnswerSetAt,
                FrontDate = data.FrontDate,
                CanReply = data.CanReply,
                CanRename = data.CanRename,
                CanDelete = data.CanDelete,
                CanHide = data.CanHide,
                IsApproved = data.IsApproved,
                HasApproved = data.HasApproved,
                HasUpvoted = data.HasUpvoted,
                CanTag = data.CanTag,
                CanEditRecipients = data.CanEditRecipients,
                CanEditGroupRecipients = data.CanEditGroupRecipients,
                CanEditUserRecipients = data.CanEditUserRecipients,
                IsPrivateDiscusion = data.IsPrivateDiscusion,
                CanSeeReactions = data.CanSeeReactions,
                IsLocked = data.IsLocked,
                CanLock = data.CanLock,
                CanSplit = data.CanSplit,
                CanMerge = data.CanMerge,
                Front = data.Front,
                CanSelectBestAnswer = data.CanSelectBestAnswer,
                IsSticky = data.IsSticky,
                CanViewWhoTypes = data.CanViewWhoTypes,
                CanMarkUnread = data.CanMarkUnread,
                CanManageReplyTemplates = data.CanManageReply
            };
        }
    }
}
