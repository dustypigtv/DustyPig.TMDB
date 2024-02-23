using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.TvSeason;

public class ValueObject
{
    [JsonPropertyName("episode_id")]
    public int EpisodeId { get; set; }

    [JsonPropertyName("episode_number")]
    public int EpisodeNumber { get; set; }
}