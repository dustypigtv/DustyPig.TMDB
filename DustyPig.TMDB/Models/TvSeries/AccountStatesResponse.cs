using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.TvSeries;

public class AccountStatesResponse
{
	public class RatedObject
	{
		[JsonPropertyName("value")]
		public int Value { get; set; }
	}


	[JsonPropertyName("id")]
	public int Id { get; set; }

	[JsonPropertyName("favorite")]
	public bool Favorite { get; set; }

	[JsonPropertyName("rated")]
	public RatedObject Rated { get; set; }

	[JsonPropertyName("watchlist")]
	public bool Watchlist { get; set; }
}
