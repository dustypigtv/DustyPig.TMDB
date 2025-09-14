using DustyPig.TMDB.JsonHelpers;
using DustyPig.TMDB.Models.Common;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Find;

public class KnownForResult
{
    [JsonPropertyName("adult")]
    public bool Adult { get; set; }

    [JsonPropertyName("backdrop_path")]
    public string BackdropPath { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <summary>
    /// Populated when <see cref="MediaType"/> == <see cref="CommonMediaTypes.Movie"/>
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; set; }

    /// <summary>
    /// Populated when <see cref="MediaType"/> == <see cref="CommonMediaTypes.Movie"/>
    /// </summary>
    [JsonPropertyName("original_title")]
    public string OriginalTitle { get; set; }

    /// <summary>
    /// Populated when <see cref="MediaType"/> == <see cref="CommonMediaTypes.TvSeries"/>
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Populated when <see cref="MediaType"/> == <see cref="CommonMediaTypes.TvSeries"/>
    /// </summary>
    [JsonPropertyName("original_name")]
    public string OriginalName { get; set; }


    [JsonPropertyName("original_language")]
    public string OriginalLanguage { get; set; }

    [JsonPropertyName("overview")]
    public string Overview { get; set; }

    [JsonPropertyName("poster_path")]
    public string PosterPath { get; set; }

    [JsonPropertyName("media_type")]
    [JsonConverter(typeof(MediaTypesConverter))]
    public CommonMediaTypes MediaType { get; set; }

    [JsonPropertyName("genre_ids")]
    public List<int> GenreIds { get; set; } = [];

    [JsonPropertyName("popularity")]
    public float Popularity { get; set; }

    /// <summary>
    /// Populated when <see cref="MediaType"/> == <see cref="CommonMediaTypes.Movie"/>
    /// </summary>
    [JsonPropertyName("release_date")]
    [JsonConverter(typeof(StringToDateOnlyConverter))]
    public DateOnly? ReleaseDate { get; set; }

    /// <summary>
    /// Populated when <see cref="MediaType"/> == <see cref="CommonMediaTypes.Movie"/>
    /// </summary>
    [JsonPropertyName("video")]
    public bool? Video { get; set; }

    [JsonPropertyName("vote_average")]
    public float VoteAverage { get; set; }

    [JsonPropertyName("vote_count")]
    public int VoteCount { get; set; }

    /// <summary>
    /// Populated when <see cref="MediaType"/> == <see cref="CommonMediaTypes.TvSeries"/>
    /// </summary>
    [JsonPropertyName("first_air_date")]
    [JsonConverter(typeof(StringToDateOnlyConverter))]
    public DateOnly? FirstAirDate { get; set; }

    /// <summary>
    /// Populated when <see cref="MediaType"/> == <see cref="CommonMediaTypes.TvSeries"/>
    /// </summary>
    [JsonPropertyName("origin_country")]
    public List<string> OriginCountry { get; set; } = [];
}
