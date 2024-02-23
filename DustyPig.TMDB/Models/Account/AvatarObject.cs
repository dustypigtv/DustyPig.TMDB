using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Account;

public class AvatarObject
{
    [JsonPropertyName("gravatar")]
    public GravatarObject Gravatar { get; set; }

    [JsonPropertyName("tmdb")]
    public TmdbObject Tmdb { get; set; }
}