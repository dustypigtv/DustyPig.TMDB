using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Person;

public class TaggedImagesResponse
{
    [JsonPropertyName("aspect_ratio")]
    public float AspectRatio { get; set; }

    [JsonPropertyName("file_path")]
    public string FilePath { get; set; }

    [JsonPropertyName("height")]
    public int Height { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>
    /// ISO-639-1 2 letter language code. E.g. &quot;en&quot;
    /// </summary>
    [JsonPropertyName("iso_639_1")]
    public string LanguageCode { get; set; }

    [JsonPropertyName("vote_average")]
    public float VoteAverage { get; set; }

    [JsonPropertyName("vote_count")]
    public int VoteCount { get; set; }

    [JsonPropertyName("width")]
    public int Width { get; set; }

    [JsonPropertyName("image_type")]
    public string ImageType { get; set; }

    [JsonPropertyName("media")]
    public MediaObject Media { get; set; }

    [JsonPropertyName("media_type")]
    public string MediaType { get; set; }
}