using DustyPig.TMDB.JsonHelpers;
using DustyPig.TMDB.Models.Common;
using System;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.TvEpisodes;

public class Item : ModelBase
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("action")]
    public string Action { get; set; }

    [JsonPropertyName("time")]
    [JsonConverter(typeof(StringToDateTimeConverter))]
    public DateTime? Time { get; set; }

    [JsonPropertyName("value")]
    public string Value { get; set; }
}