using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Authentication;

public class ValidateKeyResponse
{
	[JsonPropertyName("status_code")]
	public int StatusCode { get; set; }

	[JsonPropertyName("status_message")]
	public string StatusMessage { get; set; }

	[JsonPropertyName("success")]
	public bool Success { get; set; }
}
