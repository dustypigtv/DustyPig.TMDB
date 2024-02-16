using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.TvSeries;

public class CreditsResponse
{
	public class CastObject
	{
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

		[JsonPropertyName("character")]
		public string Character { get; set; }

		[JsonPropertyName("credit_id")]
		public string CreditId { get; set; }

		[JsonPropertyName("order")]
		public int Order { get; set; }
	}

	public class CrewObject
	{
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

		[JsonPropertyName("credit_id")]
		public string CreditId { get; set; }

		[JsonPropertyName("department")]
		public string Department { get; set; }

		[JsonPropertyName("job")]
		public string Job { get; set; }
	}


	[JsonPropertyName("cast")]
	public List<CastObject> Cast { get; set; } = [];

	[JsonPropertyName("crew")]
	public List<CrewObject> Crew { get; set; } = [];

	[JsonPropertyName("id")]
	public int Id { get; set; }
}
