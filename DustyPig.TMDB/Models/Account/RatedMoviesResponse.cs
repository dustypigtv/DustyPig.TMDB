using DustyPig.TMDB.JsonHelpers;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Account;

public class RatedMoviesResponse
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

		[JsonPropertyName("original_language")]
		public string OriginalLanguage { get; set; }

		[JsonPropertyName("original_title")]
		public string OriginalTitle { get; set; }

		[JsonPropertyName("overview")]
		public string Overview { get; set; }

		[JsonPropertyName("popularity")]
		public float Popularity { get; set; }

		[JsonPropertyName("poster_path")]
		public string PosterPath { get; set; }

		[JsonPropertyName("release_date")]
		[JsonConverter(typeof(StringToDateOnlyConverter))]
		public DateOnly? ReleaseDate { get; set; }

		[JsonPropertyName("title")]
		public string Title { get; set; }

		[JsonPropertyName("video")]
		public bool Video { get; set; }

		[JsonPropertyName("vote_average")]
		public float VoteAverage { get; set; }

		[JsonPropertyName("vote_count")]
		public int VoteCount { get; set; }

		[JsonPropertyName("rating")]
		public int Rating { get; set; }
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
