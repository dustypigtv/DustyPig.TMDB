using DustyPig.TMDB.JsonHelpers;
using DustyPig.TMDB.Models.Common;
using System;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Reviews;

public class Details : ModelBase
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("author")]
    public string Author { get; set; }

    [JsonPropertyName("author_details")]
    public CommonAuthorDetails AuthorDetails { get; set; }

    [JsonPropertyName("content")]
    public string Content { get; set; }

    [JsonPropertyName("created_at")]
    [JsonConverter(typeof(StringToDateTimeConverter))]
    public DateTime? CreatedAt { get; set; }

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

    [JsonPropertyName("media_id")]
    public int MediaId { get; set; }

    [JsonPropertyName("media_title")]
    public string MediaTitle { get; set; }

    [JsonPropertyName("media_type")]
    [JsonConverter(typeof(MediaTypesConverter))]
    public CommonMediaTypes MediaType { get; set; }

    [JsonPropertyName("updated_at")]
    [JsonConverter(typeof(StringToDateTimeConverter))]
    public DateTime? UpdatedAt { get; set; }

    [JsonPropertyName("url")]
    public string Url { get; set; }
}
