using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.List;

public class CreateResponse
{
	[JsonPropertyName("status_message")]
	public string StatusMessage { get; set; }

	[JsonPropertyName("success")]
	public bool Success { get; set; }

	[JsonPropertyName("status_code")]
	public int StatusCode { get; set; }

	[JsonPropertyName("list_id")]
	public int ListId { get; set; }
}
