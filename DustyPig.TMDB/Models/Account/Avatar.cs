using DustyPig.TMDB.Models.Common;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Account;

public class Avatar : ModelBase
{
    [JsonPropertyName("gravatar")]
    public Gravatar Gravatar { get; set; }

    [JsonPropertyName("tmdb")]
    public TmdbAvatar Tmdb { get; set; }
}