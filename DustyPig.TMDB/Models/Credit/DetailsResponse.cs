using DustyPig.TMDB.JsonHelpers;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Credit;

public class DetailsResponse
{
	public class MediaObject
	{
		public class SeasonsObject
		{
			[JsonPropertyName("air_date")]
			[JsonConverter(typeof(StringToDateOnlyConverter))]
			public DateOnly? AirDate { get; set; }

			[JsonPropertyName("episode_count")]
			public int EpisodeCount { get; set; }

			[JsonPropertyName("id")]
			public int Id { get; set; }

			[JsonPropertyName("name")]
			public string Name { get; set; }

			[JsonPropertyName("overview")]
			public string Overview { get; set; }

			[JsonPropertyName("poster_path")]
			public string PosterPath { get; set; }

			[JsonPropertyName("season_number")]
			public int SeasonNumber { get; set; }

			[JsonPropertyName("show_id")]
			public int ShowId { get; set; }
		}


		[JsonPropertyName("adult")]
		public bool Adult { get; set; }

		[JsonPropertyName("backdrop_path")]
		public string BackdropPath { get; set; }

		[JsonPropertyName("id")]
		public int Id { get; set; }

		[JsonPropertyName("name")]
		public string Name { get; set; }

		[JsonPropertyName("original_language")]
		public string OriginalLanguage { get; set; }

		[JsonPropertyName("original_name")]
		public string OriginalName { get; set; }

		[JsonPropertyName("overview")]
		public string Overview { get; set; }

		[JsonPropertyName("poster_path")]
		public string PosterPath { get; set; }

		[JsonPropertyName("media_type")]
		public string MediaType { get; set; }

		[JsonPropertyName("genre_ids")]
		public List<int> GenreIds { get; set; } = [];

		[JsonPropertyName("popularity")]
		public float Popularity { get; set; }

		[JsonPropertyName("first_air_date")]
		[JsonConverter(typeof(StringToDateOnlyConverter))]
		public DateOnly? FirstAirDate { get; set; }

		[JsonPropertyName("vote_average")]
		public float VoteAverage { get; set; }

		[JsonPropertyName("vote_count")]
		public int VoteCount { get; set; }

		[JsonPropertyName("origin_country")]
		public List<string> OriginCountry { get; set; } = [];

		[JsonPropertyName("character")]
		public string Character { get; set; }

		[JsonPropertyName("seasons")]
		public List<SeasonsObject> Seasons { get; set; } = [];
	}

	public class PersonObject
	{
		[JsonPropertyName("adult")]
		public bool Adult { get; set; }

		[JsonPropertyName("id")]
		public int Id { get; set; }

		[JsonPropertyName("name")]
		public string Name { get; set; }

		[JsonPropertyName("original_name")]
		public string OriginalName { get; set; }

		[JsonPropertyName("media_type")]
		public string MediaType { get; set; }

		[JsonPropertyName("popularity")]
		public float Popularity { get; set; }

		[JsonPropertyName("gender")]
		public int Gender { get; set; }

		[JsonPropertyName("known_for_department")]
		public string KnownForDepartment { get; set; }

		[JsonPropertyName("profile_path")]
		public string ProfilePath { get; set; }
	}


	[JsonPropertyName("credit_type")]
	public string CreditType { get; set; }

	[JsonPropertyName("department")]
	public string Department { get; set; }

	[JsonPropertyName("job")]
	public string Job { get; set; }

	[JsonPropertyName("media")]
	public MediaObject Media { get; set; }

	[JsonPropertyName("media_type")]
	public string MediaType { get; set; }

	[JsonPropertyName("id")]
	public string Id { get; set; }

	[JsonPropertyName("person")]
	public PersonObject Person { get; set; }
}
