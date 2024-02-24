using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.TvSeries;

public class ScreenedTheatrically
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("episode_number")]
    public int EpisodeNumber { get; set; }

    [JsonPropertyName("season_number")]
    public int SeasonNumber { get; set; }
}