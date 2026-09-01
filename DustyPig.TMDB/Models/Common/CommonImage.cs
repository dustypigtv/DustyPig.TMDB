using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Common;

public class CommonImage : ModelBase
{
    [JsonPropertyName("aspect_ratio")]
    public float AspectRatio { get; set; }

    [JsonPropertyName("height")]
    public int Height { get; set; }

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


    [JsonPropertyName("file_path")]
    public string FilePath { get; set; }

    [JsonPropertyName("vote_average")]
    public float VoteAverage { get; set; }

    [JsonPropertyName("vote_count")]
    public int VoteCount { get; set; }

    [JsonPropertyName("width")]
    public int Width { get; set; }
}
