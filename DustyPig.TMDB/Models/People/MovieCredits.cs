using DustyPig.TMDB.Models.Common;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.People;

public class MovieCredits : ModelBase
{
    [JsonPropertyName("cast")]
    public List<MovieCast> Cast { get; set; } = [];

    [JsonPropertyName("crew")]
    public List<MovieCrew> Crew { get; set; } = [];

    [JsonPropertyName("id")]
    public int Id { get; set; }
}
