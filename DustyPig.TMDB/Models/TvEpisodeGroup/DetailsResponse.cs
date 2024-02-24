using DustyPig.TMDB.Models.Common;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.TvEpisodeGroup;

public class DetailsResponse
{
    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("episode_count")]
    public int EpisodeCount { get; set; }

    [JsonPropertyName("group_count")]
    public int GroupCount { get; set; }

    [JsonPropertyName("groups")]
    public List<GroupsObject> Groups { get; set; } = [];

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("network")]
    public CommonCompany Network { get; set; }

    [JsonPropertyName("type")]
    public int Type { get; set; }
}
