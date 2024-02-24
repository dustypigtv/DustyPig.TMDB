using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.TvSeason;

public class CreditsResponse
{
    [JsonPropertyName("cast")]
    public List<Models.Common.CommonCast> Cast { get; set; } = [];

    [JsonPropertyName("crew")]
    public List<CrewObject2> Crew { get; set; } = [];

    [JsonPropertyName("id")]
    public int Id { get; set; }
}
