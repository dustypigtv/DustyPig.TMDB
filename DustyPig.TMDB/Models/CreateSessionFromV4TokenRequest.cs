using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models;

public class CreateSessionFromV4TokenRequest
{
    [JsonPropertyName("access_token")]
    public string AccessToken { get; set; }
}
