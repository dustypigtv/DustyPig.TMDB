using DustyPig.TMDB.JsonHelpers;
using DustyPig.TMDB.Models.Common;
using System;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Find;

public class FindSeasonResult
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("overview")]
    public string Overview { get; set; }

    [JsonPropertyName("poster_path")]
    public string PosterPath { get; set; }


    [JsonPropertyName("media_type")]
    [JsonConverter(typeof(MediaTypesConverter))]
    public CommonMediaTypes MediaType { get; set; }

    [JsonPropertyName("vote_average")]
    public float VoteAverage { get; set; }

    [JsonPropertyName("air_date")]
    [JsonConverter(typeof(StringToDateOnlyConverter))]
    public DateOnly? AirDate { get; set; }

    [JsonPropertyName("season_number")]
    public int SeasonNumber { get; set; }

    [JsonPropertyName("show_id")]
    public int ShowId { get; set; }

    [JsonPropertyName("episode_count")]
    public int EpisodeCount { get; set; }
}

