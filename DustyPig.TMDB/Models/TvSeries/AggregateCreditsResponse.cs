using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.TvSeries;

public class AggregateCreditsResponse
{
	public class CastObject
	{
		public class RolesObject
		{
			[JsonPropertyName("credit_id")]
			public string CreditId { get; set; }

			[JsonPropertyName("character")]
			public string Character { get; set; }

			[JsonPropertyName("episode_count")]
			public int EpisodeCount { get; set; }
		}


		[JsonPropertyName("adult")]
		public bool Adult { get; set; }

		[JsonPropertyName("gender")]
		public int Gender { get; set; }

		[JsonPropertyName("id")]
		public int Id { get; set; }

		[JsonPropertyName("known_for_department")]
		public string KnownForDepartment { get; set; }

		[JsonPropertyName("name")]
		public string Name { get; set; }

		[JsonPropertyName("original_name")]
		public string OriginalName { get; set; }

		[JsonPropertyName("popularity")]
		public float Popularity { get; set; }

		[JsonPropertyName("profile_path")]
		public string ProfilePath { get; set; }

		[JsonPropertyName("roles")]
		public List<RolesObject> Roles { get; set; } = [];

		[JsonPropertyName("total_episode_count")]
		public int TotalEpisodeCount { get; set; }

		[JsonPropertyName("order")]
		public int Order { get; set; }
	}

	public class CrewObject
	{
		public class JobsObject
		{
			[JsonPropertyName("credit_id")]
			public string CreditId { get; set; }

			[JsonPropertyName("job")]
			public string Job { get; set; }

			[JsonPropertyName("episode_count")]
			public int EpisodeCount { get; set; }
		}


		[JsonPropertyName("adult")]
		public bool Adult { get; set; }

		[JsonPropertyName("gender")]
		public int Gender { get; set; }

		[JsonPropertyName("id")]
		public int Id { get; set; }

		[JsonPropertyName("known_for_department")]
		public string KnownForDepartment { get; set; }

		[JsonPropertyName("name")]
		public string Name { get; set; }

		[JsonPropertyName("original_name")]
		public string OriginalName { get; set; }

		[JsonPropertyName("popularity")]
		public float Popularity { get; set; }

		[JsonPropertyName("profile_path")]
		public string ProfilePath { get; set; }

		[JsonPropertyName("jobs")]
		public List<JobsObject> Jobs { get; set; } = [];

		[JsonPropertyName("department")]
		public string Department { get; set; }

		[JsonPropertyName("total_episode_count")]
		public int TotalEpisodeCount { get; set; }
	}


	[JsonPropertyName("cast")]
	public List<CastObject> Cast { get; set; } = [];

	[JsonPropertyName("crew")]
	public List<CrewObject> Crew { get; set; } = [];

	[JsonPropertyName("id")]
	public int Id { get; set; }
}
