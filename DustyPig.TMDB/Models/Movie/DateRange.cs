using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Movie;

public class DateRange
{
    [JsonPropertyName("maximum")]
    public string Maximum { get; set; }

    [JsonPropertyName("minimum")]
    public string Minimum { get; set; }
}