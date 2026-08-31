using DustyPig.TMDB.Models.Common;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.TvSeries;

public class AggregateCredits : ModelBase
{
    [JsonPropertyName("cast")]
    public List<CommonCastAggregate> Cast { get; set; } = [];

    [JsonPropertyName("crew")]
    public List<Crew> Crew { get; set; } = [];

    [JsonPropertyName("id")]
    public int Id { get; set; }
}
