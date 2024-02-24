using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Account;

public class Gravatar
{
    [JsonPropertyName("hash")]
    public string Hash { get; set; }
}