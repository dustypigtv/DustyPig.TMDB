using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Authentication;

public class CreateSessionFromV4TokenRequest
{
    [JsonPropertyName("access_token")]
    public string AccessToken { get; set; }
}
