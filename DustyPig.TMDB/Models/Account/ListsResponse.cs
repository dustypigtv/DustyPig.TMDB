using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Account;

public class ListsResponse
{
	public class ResultsObject
	{
		[JsonPropertyName("description")]
		public string Description { get; set; }

		[JsonPropertyName("favorite_count")]
		public int FavoriteCount { get; set; }

		[JsonPropertyName("id")]
		public int Id { get; set; }

		[JsonPropertyName("item_count")]
		public int ItemCount { get; set; }

		/// <summary>
		/// ISO-639-1 2 letter language code. E.g. &quot;en&quot;
		/// </summary>
		[JsonPropertyName("iso_639_1")]
		public string LanguageCode { get; set; }

		[JsonPropertyName("list_type")]
		public string ListType { get; set; }

		[JsonPropertyName("name")]
		public string Name { get; set; }
	}


	[JsonPropertyName("page")]
	public int Page { get; set; }

	[JsonPropertyName("results")]
	public List<ResultsObject> Results { get; set; } = [];

	[JsonPropertyName("total_pages")]
	public int TotalPages { get; set; }

	[JsonPropertyName("total_results")]
	public int TotalResults { get; set; }
}