using DustyPig.TMDB.JsonHelpers;
using System;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Common;

public class CommonVideo : ModelBase
{
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

    [JsonPropertyName("key")]
    public string Key { get; set; }

    [JsonPropertyName("site")]
    public string Site { get; set; }

    [JsonPropertyName("size")]
    public int Size { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("official")]
    public bool Official { get; set; }

    [JsonPropertyName("published_at")]
    [JsonConverter(typeof(StringToDateTimeConverter))]
    public DateTime? PublishedAt { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }
}