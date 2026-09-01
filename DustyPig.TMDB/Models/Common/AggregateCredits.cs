using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Common;

public class AggregateCredits : ModelBase
{
    [JsonPropertyName("cast")]
    public List<AggregateCast> Cast { get; set; } = [];

    [JsonPropertyName("crew")]
    public List<TvCrew> Crew { get; set; } = [];

    [JsonPropertyName("id")]
    public int Id { get; set; }
}
