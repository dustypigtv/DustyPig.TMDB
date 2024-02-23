using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.TvSeason;

public class RolesObject
{
    [JsonPropertyName("credit_id")]
    public string CreditId { get; set; }

    [JsonPropertyName("character")]
    public string Character { get; set; }

    [JsonPropertyName("episode_count")]
    public int EpisodeCount { get; set; }
}