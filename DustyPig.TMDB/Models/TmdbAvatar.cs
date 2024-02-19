using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models;

public class TmdbAvatar
{
    [JsonPropertyName("avatar_path")]
    public string AvatarPath { get; set; }
}
