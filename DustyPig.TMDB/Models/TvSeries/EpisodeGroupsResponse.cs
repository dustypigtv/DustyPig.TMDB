using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.TvSeries;

public class EpisodeGroupsResponse
{
	public class ResultsObject
	{
		public class NetworkObject
		{
			[JsonPropertyName("id")]
			public int Id { get; set; }

			[JsonPropertyName("logo_path")]
			public string LogoPath { get; set; }

			[JsonPropertyName("name")]
			public string Name { get; set; }

			[JsonPropertyName("origin_country")]
			public string OriginCountry { get; set; }
		}


		[JsonPropertyName("description")]
		public string Description { get; set; }

		[JsonPropertyName("episode_count")]
		public int EpisodeCount { get; set; }

		[JsonPropertyName("group_count")]
		public int GroupCount { get; set; }

		[JsonPropertyName("id")]
		public string Id { get; set; }

		[JsonPropertyName("name")]
		public string Name { get; set; }

		[JsonPropertyName("network")]
		public NetworkObject Network { get; set; }

		[JsonPropertyName("type")]
		public int Type { get; set; }
	}


	[JsonPropertyName("results")]
	public List<ResultsObject> Results { get; set; } = [];

	[JsonPropertyName("id")]
	public int Id { get; set; }
}
