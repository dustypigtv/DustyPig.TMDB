using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Movie;

public class TranslationData
{
    [JsonPropertyName("homepage")]
    public string Homepage { get; set; }

    [JsonPropertyName("overview")]
    public string Overview { get; set; }

    [JsonPropertyName("runtime")]
    public int Runtime { get; set; }

    [JsonPropertyName("tagline")]
    public string Tagline { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }
}