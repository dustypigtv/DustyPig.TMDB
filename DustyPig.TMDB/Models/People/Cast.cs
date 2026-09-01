using DustyPig.TMDB.Enums;
using DustyPig.TMDB.JsonHelpers;
using DustyPig.TMDB.Models.Common;
using System;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.People;

/// <inheritdoc/>
public class Cast : Media
{
    [JsonPropertyName("character")]
    public string Character { get; set; }

    [JsonPropertyName("credit_id")]
    public string CreditId { get; set; }

    /// <summary>
    /// Specific to <see cref="MediaType"/> == <see cref="MediaTypes.Movie"/>
    /// </summary>
    [JsonPropertyName("order")]
    public int? Order { get; set; }

    /// <summary>
    /// Specific to <see cref="MediaType"/> == <see cref="MediaTypes.TvSeries"/>
    /// </summary>
    [JsonPropertyName("episode_count")]
    public int? EpisodeCount { get; set; }

    [JsonPropertyName("first_credit_air_date")]
    [JsonConverter(typeof(StringToDateOnlyConverter))]
    public DateOnly? FirstCreditAirDate { get; set; }
}