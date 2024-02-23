using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Person;

public class TvCreditsResponse
{
    [JsonPropertyName("cast")]
    public List<CastObject3> Cast { get; set; } = [];

    [JsonPropertyName("crew")]
    public List<CrewObject3> Crew { get; set; } = [];

    [JsonPropertyName("id")]
    public int Id { get; set; }
}
