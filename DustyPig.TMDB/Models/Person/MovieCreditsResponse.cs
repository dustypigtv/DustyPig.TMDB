using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Person;

public class MovieCreditsResponse
{
    [JsonPropertyName("cast")]
    public List<CastObject2> Cast { get; set; } = [];

    [JsonPropertyName("crew")]
    public List<CrewObject2> Crew { get; set; } = [];

    [JsonPropertyName("id")]
    public int Id { get; set; }
}
