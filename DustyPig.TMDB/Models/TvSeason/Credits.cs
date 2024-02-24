using DustyPig.TMDB.Models.Common;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.TvSeason;

public class Credits
{
    [JsonPropertyName("cast")]
    public List<CommonCast1> Cast { get; set; } = [];

    [JsonPropertyName("crew")]
    public List<Crew2> Crew { get; set; } = [];

    [JsonPropertyName("id")]
    public int Id { get; set; }
}
