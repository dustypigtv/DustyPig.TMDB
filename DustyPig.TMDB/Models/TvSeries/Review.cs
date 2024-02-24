using DustyPig.TMDB.JsonHelpers;
using DustyPig.TMDB.Models.Common;
using System;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.TvSeries;

public class Review
{
    [JsonPropertyName("author")]
    public string Author { get; set; }

    [JsonPropertyName("author_details")]
    public CommonAuthorDetails AuthorDetails { get; set; }

    [JsonPropertyName("content")]
    public string Content { get; set; }

    [JsonPropertyName("created_at")]
    [JsonConverter(typeof(StringToDateTimeConverter))]
    public DateTime? CreatedAt { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("updated_at")]
    [JsonConverter(typeof(StringToDateTimeConverter))]
    public DateTime? UpdatedAt { get; set; }

    [JsonPropertyName("url")]
    public string Url { get; set; }
}