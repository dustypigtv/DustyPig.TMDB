using DustyPig.TMDB.Models.Common;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Account;

public class Details : ModelBase
{
    [JsonPropertyName("avatar")]
    public Avatar Avatar { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <summary>
    /// ISO-639-1 2 letter language code. E.g. &quot;en&quot;
    /// </summary>
    [JsonPropertyName("iso_639_1")]
    public string ISO_639_1 { get; set; }

    /// <summary>
    /// Links to <see cref="ISO_639_1"/>. 
    /// This property is not serialized.
    /// </summary>
    [JsonIgnore]
    public string LanguageCode
    {
        get => ISO_639_1;
        set => ISO_639_1 = value;
    }

    /// <summary>
    /// ISO-3166-1 2 letter country code. E.g. &quot;US&quot;
    /// </summary>
    [JsonPropertyName("iso_3166_1")]
    public string ISO_3166_1 { get; set; }

    /// <summary>
    /// Links to <see cref="ISO_3166_1"/>.
    /// This property is not serialized
    /// </summary>
    [JsonIgnore]
    public string CountryCode
    {
        get => ISO_3166_1;
        set => ISO_3166_1 = value;
    }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("include_adult")]
    public bool IncludeAdult { get; set; }

    [JsonPropertyName("username")]
    public string Username { get; set; }
}
