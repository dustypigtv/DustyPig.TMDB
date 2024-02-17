using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Authentication;

public class CreateSessionWithLoginRequest
{
	[JsonPropertyName("username")]
	public string Username { get; set; }

	[JsonPropertyName("password")]
	public string Password { get; set; }

	[JsonPropertyName("request_token")]
	public string RequestToken { get; set; }
}
