using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Common;

public class CommonCountry1
{
    /// <summary>
    /// ISO-3166-1 2 letter country code. E.g. &quot;US&quot;
    /// </summary>
    [JsonPropertyName("iso_3166_1")]
    public string CountryCode { get; set; }

    [JsonPropertyName("english_name")]
    public string EnglishName { get; set; }

    [JsonPropertyName("native_name")]
    public string NativeName { get; set; }
}
