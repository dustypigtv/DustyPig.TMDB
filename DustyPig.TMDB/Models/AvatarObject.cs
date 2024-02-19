using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models;

public class Avatar
{
    [JsonPropertyName("gravatar")]
    public Gravatar Gravatar { get; set; }

    [JsonPropertyName("tmdb")]
    public TmdbAvatar Tmdb { get; set; }
}