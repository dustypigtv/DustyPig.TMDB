using DustyPig.TMDB.JsonHelpers;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Common;

public class CommonRatedMovie
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
    public float Rating { get; set; }
}