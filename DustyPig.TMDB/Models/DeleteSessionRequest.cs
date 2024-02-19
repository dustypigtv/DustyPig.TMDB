using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models;

public class DeleteSessionRequest
{
    [JsonPropertyName("session_id")]
    public string SessionId { get; set; }
}
