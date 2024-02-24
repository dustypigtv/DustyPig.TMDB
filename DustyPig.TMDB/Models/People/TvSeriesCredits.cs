using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.People;

public class TvSeriesCredits
{
    [JsonPropertyName("cast")]
    public List<Cast3> Cast { get; set; } = [];

    [JsonPropertyName("crew")]
    public List<Crew3> Crew { get; set; } = [];

    [JsonPropertyName("id")]
    public int Id { get; set; }
}
