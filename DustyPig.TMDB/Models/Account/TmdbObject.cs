using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Account;

public class TmdbObject
{
    [JsonPropertyName("avatar_path")]
    public string AvatarPath { get; set; }
}