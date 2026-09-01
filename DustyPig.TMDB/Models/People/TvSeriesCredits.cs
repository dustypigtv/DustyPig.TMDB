using DustyPig.TMDB.Models.Common;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.People;

public class TvSeriesCredits : ModelBase
{
    [JsonPropertyName("cast")]
    public List<TvSeriesCast> Cast { get; set; } = [];

    [JsonPropertyName("crew")]
    public List<TvSeriesCrew> Crew { get; set; } = [];

    [JsonPropertyName("id")]
    public int Id { get; set; }
}
