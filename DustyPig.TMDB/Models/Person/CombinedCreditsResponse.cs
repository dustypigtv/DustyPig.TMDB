using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Person;

public class CombinedCreditsResponse
{
    [JsonPropertyName("cast")]
    public List<CastObject> Cast { get; set; } = [];

    [JsonPropertyName("crew")]
    public List<CrewObject> Crew { get; set; } = [];

    [JsonPropertyName("id")]
    public int Id { get; set; }
}
