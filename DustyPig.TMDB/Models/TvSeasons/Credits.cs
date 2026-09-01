using DustyPig.TMDB.Models.Common;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.TvSeasons;

public class Credits : ModelBase
{
    [JsonPropertyName("cast")]
    public List<CommonCast> Cast { get; set; } = [];

    [JsonPropertyName("crew")]
    public List<Crew> Crew { get; set; } = [];

    [JsonPropertyName("id")]
    public int Id { get; set; }
}
