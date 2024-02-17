using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Search;

public class KeywordResponse
{
	public class ResultsObject
	{
		[JsonPropertyName("id")]
		public int Id { get; set; }

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
