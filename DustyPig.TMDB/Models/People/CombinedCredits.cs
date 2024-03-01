using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.People;

public class CombinedCredits
{
    [JsonPropertyName("cast")]
    public List<Cast> Cast { get; set; } = [];

    [JsonPropertyName("crew")]
    public List<Crew> Crew { get; set; } = [];

    [JsonPropertyName("id")]
    public int Id { get; set; }
}
