using DustyPig.TMDB.JsonHelpers;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.GuestSession;

public class RatedTvResponse
{
	public class ResultsObject
	{
		[JsonPropertyName("adult")]
		public bool Adult { get; set; }

		[JsonPropertyName("backdrop_path")]
		public string BackdropPath { get; set; }

		[JsonPropertyName("genre_ids")]
		public List<int> GenreIds { get; set; } = [];

		[JsonPropertyName("id")]
		public int Id { get; set; }

		[JsonPropertyName("origin_country")]
		public List<string> OriginCountry { get; set; } = [];

		[JsonPropertyName("original_language")]
		public string OriginalLanguage { get; set; }

		[JsonPropertyName("original_name")]
		public string OriginalName { get; set; }

		[JsonPropertyName("overview")]
		public string Overview { get; set; }

		[JsonPropertyName("popularity")]
		public float Popularity { get; set; }

		[JsonPropertyName("poster_path")]
		public string PosterPath { get; set; }

		[JsonPropertyName("first_air_date")]
		[JsonConverter(typeof(StringToDateOnlyConverter))]
		public DateOnly? FirstAirDate { get; set; }

		[JsonPropertyName("name")]
		public string Name { get; set; }

		[JsonPropertyName("vote_average")]
		public float VoteAverage { get; set; }

		[JsonPropertyName("vote_count")]
		public int VoteCount { get; set; }

		[JsonPropertyName("rating")]
		public float Rating { get; set; }
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
