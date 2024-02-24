using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Common;

public class CommonValue1
{
    [JsonPropertyName("value")]
    public float Value { get; set; }
}
