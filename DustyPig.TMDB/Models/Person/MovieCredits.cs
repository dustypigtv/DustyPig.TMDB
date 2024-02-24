using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Person;

public class MovieCredits
{
    [JsonPropertyName("cast")]
    public List<Cast2> Cast { get; set; } = [];

    [JsonPropertyName("crew")]
    public List<Crew2> Crew { get; set; } = [];

    [JsonPropertyName("id")]
    public int Id { get; set; }
}
