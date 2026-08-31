using DustyPig.TMDB.Models.Common;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Account;

public class TmdbAvatar : ModelBase
{
    [JsonPropertyName("avatar_path")]
    public string AvatarPath { get; set; }
}