using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Common;

public class CommonAggregateCredits : ModelBase
{
    [JsonPropertyName("cast")]
    public List<CommonCastAggregate> Cast { get; set; } = [];

    [JsonPropertyName("crew")]
    public List<CommonTvCrew> Crew { get; set; } = [];

    [JsonPropertyName("id")]
    public int Id { get; set; }
}
