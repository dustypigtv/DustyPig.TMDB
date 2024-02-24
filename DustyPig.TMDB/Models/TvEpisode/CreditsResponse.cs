using System.Collections.Generic;
using System.Text.Json.Serialization;
using DustyPig.TMDB.Models.Common;

namespace DustyPig.TMDB.Models.TvEpisode;

public class CreditsResponse
{
    [JsonPropertyName("cast")]
    public List<CastObject4> Cast { get; set; } = [];

    [JsonPropertyName("crew")]
    public List<CrewObject> Crew { get; set; } = [];

    [JsonPropertyName("guest_stars")]
    public List<CastObject4> GuestStars { get; set; } = [];

    [JsonPropertyName("id")]
    public int Id { get; set; }
}
