using DustyPig.TMDB.JsonHelpers;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Common;

public class CommonMedia : ModelBase
{

    [JsonPropertyName("title")]
    public string ObjectTitle { get; set; }

    [JsonPropertyName("name")]
    public string ObjectName { get; set; }

    /// <summary>
    /// For movies, this is the 'title' property.
    /// For tv, this is the 'name' property.
    /// </summary>
    [JsonIgnore]
    public string Title => Utils.Coalesce(ObjectTitle, ObjectName);

    [JsonPropertyName("original_title")]
    public string ObjectOriginalTitle { get; set; }

    [JsonPropertyName("original_name")]
    public string ObjectOriginalName { get; set; }

    /// <summary>
    /// For movies, this is the 'original_title' property.
    /// For tv, this is the 'original_name' property.
    /// </summary>
    [JsonIgnore]
    public string OriginalTitle => Utils.Coalesce(ObjectOriginalTitle, ObjectOriginalName);



    [JsonPropertyName("release_date")]
    [JsonConverter(typeof(StringToDateOnlyConverter))]
    public DateOnly? ObjectReleaseDate { get; set; }

    [JsonPropertyName("first_air_date")]
    [JsonConverter(typeof(StringToDateOnlyConverter))]
    public DateOnly? ObjectFirstAirDate { get; set; }

    /// <summary>
    /// For movies, this is the 'release_date' property.
    /// For tv, this is the 'first_air_date' property.
    /// </summary>
    [JsonIgnore]
    public DateOnly? Date => Utils.Coalesce(ObjectReleaseDate, ObjectFirstAirDate);








    [JsonPropertyName("adult")]
    public bool Adult { get; set; }

    [JsonPropertyName("softcore")]
    public bool SoftCore { get; set; }

    [JsonPropertyName("backdrop_path")]
    public string BackdropPath { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("original_language")]
    public string OriginalLanguage { get; set; }

    [JsonPropertyName("origin_country")]
    public List<string> OriginCountry { get; set; } = [];






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


    [JsonPropertyName("video")]
    public bool? Video { get; set; }

    [JsonPropertyName("vote_average")]
    public float VoteAverage { get; set; }

    [JsonPropertyName("vote_count")]
    public int VoteCount { get; set; }

    [JsonPropertyName("rating")]
    public float? Rating { get; set; }
}