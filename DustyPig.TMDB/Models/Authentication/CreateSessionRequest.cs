using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Authentication;

public class CreateSessionRequest
{
	[JsonPropertyName("request_token")]
	public string RequestToken { get; set; }
}
