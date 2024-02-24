using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.TvSeries;

public class Seasons2
{
    [JsonPropertyName("episode_count")]
    public int EpisodeCount { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("overview")]
    public string Overview { get; set; }

    [JsonPropertyName("season_number")]
    public int SeasonNumber { get; set; }
}