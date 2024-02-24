using DustyPig.TMDB.JsonHelpers;
using DustyPig.TMDB.Models.Common;
using System;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Reviews;

public class Details
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
    public string LanguageCode { get; set; }

    [JsonPropertyName("media_id")]
    public int MediaId { get; set; }

    [JsonPropertyName("media_title")]
    public string MediaTitle { get; set; }

    [JsonPropertyName("media_type")]
    [JsonConverter(typeof(MediaTypesConverter))]
    public MediaTypes MediaType { get; set; }

    [JsonPropertyName("updated_at")]
    [JsonConverter(typeof(StringToDateTimeConverter))]
    public DateTime? UpdatedAt { get; set; }

    [JsonPropertyName("url")]
    public string Url { get; set; }
}
