using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models;

public class Gravatar
{
    [JsonPropertyName("hash")]
    public string Hash { get; set; }
}
