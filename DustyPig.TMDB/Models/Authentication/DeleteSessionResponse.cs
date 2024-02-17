using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Authentication;

public class DeleteSessionResponse
{
	[JsonPropertyName("success")]
	public bool Success { get; set; }
}
