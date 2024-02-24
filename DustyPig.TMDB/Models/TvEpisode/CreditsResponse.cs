using DustyPig.TMDB.Models.Common;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.TvEpisode;

public class CreditsResponse
{
    [JsonPropertyName("cast")]
    public List<CommonCast1> Cast { get; set; } = [];

    [JsonPropertyName("crew")]
    public List<CommonCrew> Crew { get; set; } = [];

    [JsonPropertyName("guest_stars")]
    public List<CommonCast1> GuestStars { get; set; } = [];

    [JsonPropertyName("id")]
    public int Id { get; set; }
}
