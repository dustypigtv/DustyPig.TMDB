using DustyPig.TMDB.JsonHelpers;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Account;

public class RatedTvEpisodesResponse
{
    [JsonPropertyName("air_date")]
    [JsonConverter(typeof(StringToDateOnlyConverter))]
    public DateOnly? AirDate { get; set; }

    [JsonPropertyName("episode_number")]
    public int EpisodeNumber { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("overview")]
    public string Overview { get; set; }

    [JsonPropertyName("production_code")]
    public string ProductionCode { get; set; }

    [JsonPropertyName("runtime")]
    public int Runtime { get; set; }

    [JsonPropertyName("season_number")]
    public int SeasonNumber { get; set; }

    [JsonPropertyName("show_id")]
    public int ShowId { get; set; }

    [JsonPropertyName("still_path")]
    public string StillPath { get; set; }

    [JsonPropertyName("vote_average")]
    public float VoteAverage { get; set; }

    [JsonPropertyName("vote_count")]
    public int VoteCount { get; set; }

    [JsonPropertyName("rating")]
    public int Rating { get; set; }
}