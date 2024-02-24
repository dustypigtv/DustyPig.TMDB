using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Common;

public class CommonAlternativeName
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }
}