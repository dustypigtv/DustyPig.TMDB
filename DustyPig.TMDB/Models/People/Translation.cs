using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.People;

public class Translation
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("biography")]
    public string Biography { get; set; }

    [JsonPropertyName("primary")]
    public bool Primary { get; set; }
}