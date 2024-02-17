using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Account;

public class AddToWatchlistResponse
{
	[JsonPropertyName("status_code")]
	public int StatusCode { get; set; }

	[JsonPropertyName("status_message")]
	public string StatusMessage { get; set; }
}
