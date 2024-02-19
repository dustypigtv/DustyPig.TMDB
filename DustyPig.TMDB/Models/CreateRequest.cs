using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models;

public class CreateRequest
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("language")]
    public string Language { get; set; } = "en-US";
}
