using DustyPig.TMDB.JsonHelpers;
using System;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Common;

public class DateRange : ModelBase
{
    [JsonPropertyName("maximum")]
    [JsonConverter(typeof(StringToDateOnlyConverter))]
    public DateOnly? Maximum { get; set; }

    [JsonPropertyName("minimum")]
    [JsonConverter(typeof(StringToDateOnlyConverter))]
    public DateOnly? Minimum { get; set; }
}