using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Movie;

public class ProductionCountriesObject
{
    /// <summary>
    /// ISO-3166-1 2 letter country code. E.g. &quot;US&quot;
    /// </summary>
    [JsonPropertyName("iso_3166_1")]
    public string CountryCode { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }
}