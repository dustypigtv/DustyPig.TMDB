using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.TvEpisodeGroup;

public class GroupsObject
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("order")]
    public int Order { get; set; }

    [JsonPropertyName("episodes")]
    public List<EpisodesObject> Episodes { get; set; } = [];

    [JsonPropertyName("locked")]
    public bool Locked { get; set; }
}