using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Movie;

public class ValueObject
{
    [JsonPropertyName("poster")]
    public PosterObject Poster { get; set; }
}