using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Common;

public class TitleObject : ModelBase
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

    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }
}