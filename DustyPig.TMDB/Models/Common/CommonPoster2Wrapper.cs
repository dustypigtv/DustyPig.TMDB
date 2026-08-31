using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Common;

public class CommonPoster2Wrapper : ModelBase
{
    [JsonPropertyName("poster")]
    public CommonPoster2 Poster { get; set; }
}