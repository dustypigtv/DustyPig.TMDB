using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.TvEpisodeGroups;

public class Group
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("order")]
    public int Order { get; set; }

    [JsonPropertyName("episodes")]
    public List<Episode> Episodes { get; set; } = [];

    [JsonPropertyName("locked")]
    public bool Locked { get; set; }
}