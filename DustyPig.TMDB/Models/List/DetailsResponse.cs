using DustyPig.TMDB.Models.Common;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.List;

public class DetailsResponse
{
    [JsonPropertyName("created_by")]
    public string CreatedBy { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("favorite_count")]
    public int FavoriteCount { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("items")]
    public List<CommonMedia> Items { get; set; } = [];

    [JsonPropertyName("item_count")]
    public int ItemCount { get; set; }

    /// <summary>
    /// ISO-639-1 2 letter language code. E.g. &quot;en&quot;
    /// </summary>
    [JsonPropertyName("iso_639_1")]
    public string LanguageCode { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("poster_path")]
    public string PosterPath { get; set; }
}
