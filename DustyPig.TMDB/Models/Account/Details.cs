using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Account;

public class Details
{
    [JsonPropertyName("avatar")]
    public Avatar Avatar { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <summary>
    /// ISO-639-1 2 letter language code. E.g. &quot;en&quot;
    /// </summary>
    [JsonPropertyName("iso_639_1")]
    public string LanguageCode { get; set; }

    /// <summary>
    /// ISO-3166-1 2 letter country code. E.g. &quot;US&quot;
    /// </summary>
    [JsonPropertyName("iso_3166_1")]
    public string CountryCode { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("include_adult")]
    public bool IncludeAdult { get; set; }

    [JsonPropertyName("username")]
    public string Username { get; set; }
}
