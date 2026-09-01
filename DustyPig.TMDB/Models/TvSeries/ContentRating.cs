using DustyPig.TMDB.Models.Common;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.TvSeries;

public class ContentRating : ModelBase
{
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

    [JsonPropertyName("rating")]
    public string Rating { get; set; }


    /// <summary>
    /// TO DO
    /// </summary>
    [JsonPropertyName("descriptors")]
    public JsonElement Descriptors { get; set; }
}