using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Movie;

public class CreditsResponse
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("cast")]
    public List<CastObject> Cast { get; set; } = [];

    [JsonPropertyName("crew")]
    public List<CrewObject> Crew { get; set; } = [];
}
