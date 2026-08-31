using DustyPig.TMDB.Models.Common;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Authentication;

public class CreateSessionFromV4TokenRequest : ModelBase
{
    [JsonPropertyName("access_token")]
    public string AccessToken { get; set; }
}
