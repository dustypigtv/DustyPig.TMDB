using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Authentication;

public class CreateSessionResponse
{
    [JsonPropertyName("success")]
    public bool Success { get; set; }

    [JsonPropertyName("session_id")]
    public string SessionId { get; set; }
}
