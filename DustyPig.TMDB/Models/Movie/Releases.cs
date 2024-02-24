using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Movie;

public class Releases
{
    /// <summary>
    /// ISO-3166-1 2 letter country code. E.g. &quot;US&quot;
    /// </summary>
    [JsonPropertyName("iso_3166_1")]
    public string CountryCode { get; set; }

    [JsonPropertyName("release_dates")]
    public List<Release> ReleaseDates { get; set; } = [];
}