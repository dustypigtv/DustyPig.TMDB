using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.TvEpisode;

public class AddRatingRequest
{
    [JsonPropertyName("value")]
    public float Value { get; set; }
}
