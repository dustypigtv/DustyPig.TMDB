using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Changes;

public class PeopleListResponse
{
	public class ResultsObject
	{
		[JsonPropertyName("id")]
		public int Id { get; set; }

		[JsonPropertyName("adult")]
		public bool Adult { get; set; }
	}


	[JsonPropertyName("results")]
	public List<ResultsObject> Results { get; set; } = [];

	[JsonPropertyName("page")]
	public int Page { get; set; }

	[JsonPropertyName("total_pages")]
	public int TotalPages { get; set; }

	[JsonPropertyName("total_results")]
	public int TotalResults { get; set; }
}
