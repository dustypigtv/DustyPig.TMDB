using DustyPig.TMDB.JsonHelpers;
using System.Text.Json.Serialization;
using System;

namespace DustyPig.TMDB.Models.TvSeason;

public class ItemsObject
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("action")]
    public string Action { get; set; }

    [JsonPropertyName("time")]
    [JsonConverter(typeof(StringToDateTimeConverter))]
    public DateTime? Time { get; set; }

    [JsonPropertyName("value")]
    public ValueObject Value { get; set; }
}