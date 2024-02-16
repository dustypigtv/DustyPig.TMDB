using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Authentication;

public class CreateSessionFromV4TokenResponse
{
	[JsonPropertyName("success")]
	public bool Success { get; set; }

	[JsonPropertyName("session_id")]
	public string SessionId { get; set; }
}
