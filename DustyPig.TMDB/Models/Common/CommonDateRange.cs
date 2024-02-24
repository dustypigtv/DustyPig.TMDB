using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Common;

public class CommonDateRange
{
    [JsonPropertyName("maximum")]
    public string Maximum { get; set; }

    [JsonPropertyName("minimum")]
    public string Minimum { get; set; }
}