using DustyPig.TMDB.JsonHelpers;
using System;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.TvSeasons;

public class Item
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("action")]
    public string Action { get; set; }

    [JsonPropertyName("time")]
    [JsonConverter(typeof(StringToDateTimeConverter))]
    public DateTime? Time { get; set; }

    [JsonPropertyName("value")]
    public Value Value { get; set; }
}