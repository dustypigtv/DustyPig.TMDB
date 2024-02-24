using DustyPig.TMDB.Models.Common;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.TvSeasons;

public class AggregateCredits
{
    [JsonPropertyName("cast")]
    public List<CommonCast2> Cast { get; set; } = [];

    [JsonPropertyName("crew")]
    public List<Crew1> Crew { get; set; } = [];

    [JsonPropertyName("id")]
    public int Id { get; set; }
}
