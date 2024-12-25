using Flarum.Api.Bases.ModelBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Flarum.Api.Models.ResponseModel
{
    public class FlarumTagDto : FlarumModelBase
    {
        [JsonPropertyName("name")] public string Name { get; set; }
        [JsonPropertyName("description")] public string Description { get; set; }
        [JsonPropertyName("slug")] public string Slug { get; set; }
        [JsonPropertyName("color")] public string Color { get; set; }
        [JsonPropertyName("backgroundUrl")] public object BackgroundUrl { get; set; }
        [JsonPropertyName("backgroundMode")] public object BackgroundMode { get; set; }
        [JsonPropertyName("icon")] public string Icon { get; set; }
        [JsonPropertyName("discussionCount")] public int DiscussionCount { get; set; }
        [JsonPropertyName("position")] public int Position { get; set; }
        [JsonPropertyName("defaultSort")] public object DefaultSort { get; set; }
        [JsonPropertyName("isChild")] public bool IsChild { get; set; }
        [JsonPropertyName("isHidden")] public bool IsHidden { get; set; }
        [JsonPropertyName("lastPostedAt")] public DateTime LastPostedAt { get; set; }
        [JsonPropertyName("canStartDiscussion")] public bool CanStartDiscussion { get; set; }
        [JsonPropertyName("canAddToDiscussion")] public bool CanAddToDiscussion { get; set; }
        [JsonPropertyName("subscription")] public object Subscription { get; set; }
        [JsonPropertyName("richExcerpts")] public object RichExcerpts { get; set; }
        [JsonPropertyName("excerptLength")] public object ExcerptLength { get; set; }
        [JsonPropertyName("isQnA")] public bool IsQnA { get; set; }
        [JsonPropertyName("reminders")] public bool Reminders { get; set; }
        [JsonPropertyName("template")] public string Template { get; set; }
    }
}
