using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Person;

public class CombinedCredits
{
    [JsonPropertyName("cast")]
    public List<Cast1> Cast { get; set; } = [];

    [JsonPropertyName("crew")]
    public List<Crew1> Crew { get; set; } = [];

    [JsonPropertyName("id")]
    public int Id { get; set; }
}
