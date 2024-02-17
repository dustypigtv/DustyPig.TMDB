using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Account;

public class AddFavoriteRequest
{
	[JsonPropertyName("media_type")]
	public string MediaType { get; set; }

	[JsonPropertyName("media_id")]
	public int MediaId { get; set; }

	[JsonPropertyName("favorite")]
	public bool Favorite { get; set; }
}
