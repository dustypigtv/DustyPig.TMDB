using DustyPig.TMDB.Enums;
using DustyPig.TMDB.JsonHelpers;
using DustyPig.TMDB.Models.Common;
using System;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Credits;

public class Season : ModelBase
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

    /// <summary>
    /// This is undocumented, and <see cref="VoteCount"/> is always missing, so this is probably not useful
    /// </summary>
    [JsonPropertyName("vote_average")]
    public float VoteAverage { get; set; }

    /// <summary>
    /// This seems to always be missing
    /// </summary>
    [JsonPropertyName("vote_count")]
    public int? VoteCount { get; set; }

    [JsonPropertyName("media_type")]
    [JsonConverter(typeof(MediaTypesConverter))]
    public MediaTypes MediaType { get; set; }
}