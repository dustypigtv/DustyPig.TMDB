using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Account;

public class GravatarObject
{
    [JsonPropertyName("hash")]
    public string Hash { get; set; }
}