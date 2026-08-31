using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Common;

public class CommonList : ModelBase
{
    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("favorite_count")]
    public int FavoriteCount { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("item_count")]
    public int ItemCount { get; set; }

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

    [JsonPropertyName("list_type")]
    public string ListType { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }
}