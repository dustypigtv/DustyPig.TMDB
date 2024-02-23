using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Movie;

public class TranslationsObject
{
    /// <summary>
    /// ISO-3166-1 2 letter country code. E.g. &quot;US&quot;
    /// </summary>
    [JsonPropertyName("iso_3166_1")]
    public string CountryCode { get; set; }

    /// <summary>
    /// ISO-639-1 2 letter language code. E.g. &quot;en&quot;
    /// </summary>
    [JsonPropertyName("iso_639_1")]
    public string LanguageCode { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("english_name")]
    public string EnglishName { get; set; }

    [JsonPropertyName("data")]
    public DataObject Data { get; set; }
}