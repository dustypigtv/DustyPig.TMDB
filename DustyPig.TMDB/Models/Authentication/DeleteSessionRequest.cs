using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Authentication;

public class DeleteSessionRequest
{
    [JsonPropertyName("session_id")]
    public string SessionId { get; set; }
}
