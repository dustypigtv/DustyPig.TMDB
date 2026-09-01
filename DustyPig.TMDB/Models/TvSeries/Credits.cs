using DustyPig.TMDB.Models.Common;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.TvSeries;

public class Credits : ModelBase
{
    [JsonPropertyName("cast")]
    public List<CommonCast> Cast { get; set; } = [];

    [JsonPropertyName("crew")]
    public List<CommonTvCrew> Crew { get; set; } = [];

    [JsonPropertyName("id")]
    public int Id { get; set; }
}
