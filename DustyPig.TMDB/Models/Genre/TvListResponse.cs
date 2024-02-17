using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Genre;

public class TvListResponse
{
	public class GenresObject
	{
		[JsonPropertyName("id")]
		public int Id { get; set; }

		[JsonPropertyName("name")]
		public string Name { get; set; }
	}


	[JsonPropertyName("genres")]
	public List<GenresObject> Genres { get; set; } = [];
}
