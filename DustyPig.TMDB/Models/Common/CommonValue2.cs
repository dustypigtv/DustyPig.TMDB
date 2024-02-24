using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Common;

public class CommonValue2
{
    [JsonPropertyName("poster")]
    public CommonPoster2 Poster { get; set; }
}