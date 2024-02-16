using DustyPig.TMDB.JsonHelpers;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.TvSeries;

public class LatestResponse
{
	public class LastEpisodeToAirObject
	{
		[JsonPropertyName("id")]
		public int Id { get; set; }

		[JsonPropertyName("name")]
		public string Name { get; set; }

		[JsonPropertyName("overview")]
		public string Overview { get; set; }

		[JsonPropertyName("vote_average")]
		public float VoteAverage { get; set; }

		[JsonPropertyName("vote_count")]
		public int VoteCount { get; set; }

		[JsonPropertyName("air_date")]
		[JsonConverter(typeof(StringToDateOnlyConverter))]
		public DateOnly? AirDate { get; set; }

		[JsonPropertyName("episode_number")]
		public int EpisodeNumber { get; set; }

		[JsonPropertyName("production_code")]
		public string ProductionCode { get; set; }

		[JsonPropertyName("season_number")]
		public int SeasonNumber { get; set; }

		[JsonPropertyName("show_id")]
		public int ShowId { get; set; }
	}

	public class SeasonsObject
	{
		[JsonPropertyName("episode_count")]
		public int EpisodeCount { get; set; }

		[JsonPropertyName("id")]
		public int Id { get; set; }

		[JsonPropertyName("name")]
		public string Name { get; set; }

		[JsonPropertyName("overview")]
		public string Overview { get; set; }

		[JsonPropertyName("season_number")]
		public int SeasonNumber { get; set; }
	}


	[JsonPropertyName("adult")]
	public bool Adult { get; set; }

	[JsonPropertyName("first_air_date")]
	[JsonConverter(typeof(StringToDateOnlyConverter))]
	public DateOnly? FirstAirDate { get; set; }

	[JsonPropertyName("homepage")]
	public string Homepage { get; set; }

	[JsonPropertyName("id")]
	public int Id { get; set; }

	[JsonPropertyName("in_production")]
	public bool InProduction { get; set; }

	[JsonPropertyName("last_air_date")]
	[JsonConverter(typeof(StringToDateOnlyConverter))]
	public DateOnly? LastAirDate { get; set; }

	[JsonPropertyName("last_episode_to_air")]
	public LastEpisodeToAirObject LastEpisodeToAir { get; set; }

	[JsonPropertyName("name")]
	public string Name { get; set; }

	[JsonPropertyName("number_of_episodes")]
	public int NumberOfEpisodes { get; set; }

	[JsonPropertyName("number_of_seasons")]
	public int NumberOfSeasons { get; set; }

	[JsonPropertyName("origin_country")]
	public List<string> OriginCountry { get; set; } = [];

	[JsonPropertyName("original_language")]
	public string OriginalLanguage { get; set; }

	[JsonPropertyName("original_name")]
	public string OriginalName { get; set; }

	[JsonPropertyName("overview")]
	public string Overview { get; set; }

	[JsonPropertyName("popularity")]
	public int Popularity { get; set; }

	[JsonPropertyName("seasons")]
	public List<SeasonsObject> Seasons { get; set; } = [];

	[JsonPropertyName("status")]
	public string Status { get; set; }

	[JsonPropertyName("tagline")]
	public string Tagline { get; set; }

	[JsonPropertyName("type")]
	public string Type { get; set; }

	[JsonPropertyName("vote_average")]
	public float VoteAverage { get; set; }

	[JsonPropertyName("vote_count")]
	public int VoteCount { get; set; }
}
