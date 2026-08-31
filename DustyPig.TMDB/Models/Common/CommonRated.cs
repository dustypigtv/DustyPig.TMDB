using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Common;

public class CommonRated : ModelBase
{
    [JsonPropertyName("value")]
    public float? Value { get; set; } 
}
