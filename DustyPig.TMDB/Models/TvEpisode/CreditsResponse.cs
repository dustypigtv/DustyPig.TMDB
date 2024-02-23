using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.TvEpisode;

public class CreditsResponse
{
    [JsonPropertyName("cast")]
    public List<CastObject> Cast { get; set; } = [];

    [JsonPropertyName("crew")]
    public List<CrewObject> Crew { get; set; } = [];

    [JsonPropertyName("guest_stars")]
    public List<GuestStarsObject> GuestStars { get; set; } = [];

    [JsonPropertyName("id")]
    public int Id { get; set; }
}
