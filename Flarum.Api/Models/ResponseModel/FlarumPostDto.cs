using Flarum.Api.Bases.ModelBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Flarum.Api.Models.ResponseModel
{
    public class FlarumPostDto : FlarumModelBase
    {
        [JsonPropertyName("number")] public string Number { get; set; }
        [JsonPropertyName("createdAt")] public DateTime CreatedAt { get; set; }
        [JsonPropertyName("contentType")] public string ContentType { get; set; }
        [JsonPropertyName("contentHtml")] public string ContentHtml { get; set; }
        [JsonPropertyName("renderFailed")] public bool RenderFailed { get; set; }
        [JsonPropertyName("canEdit")] public bool CanEdit { get; set; }
        [JsonPropertyName("canDelete")] public bool CanDelete { get; set; }
        [JsonPropertyName("canHide")] public bool CanHide { get; set; }
        [JsonPropertyName("canFlag")] public bool CanFlag { get; set; }
        [JsonPropertyName("isApproved")] public bool IsApproved { get; set; }
        [JsonPropertyName("canApprove")] public bool CanApprove { get; set; }
        [JsonPropertyName("canReact")] public bool CanReact { get; set; }
        [JsonPropertyName("hasUpvoted")] public bool HasUpvoted { get; set; }
        [JsonPropertyName("hasDownvoted")] public bool HasDownvoted { get; set; }
        [JsonPropertyName("canSeeVotes")] public bool CanSeeVotes { get; set; }
        [JsonPropertyName("votes")] public int Votes { get; set; }
        [JsonPropertyName("canVote")] public bool CanVote { get; set; }
        [JsonPropertyName("seeVoters")] public bool SeeVoters { get; set; }
        [JsonPropertyName("canViewEditHistory")] public bool CanViewEditHistory { get; set; }
        [JsonPropertyName("canDeleteEditHistory")] public bool CanDeleteEditHistory { get; set; }
        [JsonPropertyName("canRollbackEditHistory")] public bool CanRollbackEditHistory { get; set; }
    }
}
