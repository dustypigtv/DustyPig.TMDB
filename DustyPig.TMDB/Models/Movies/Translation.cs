using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Movies;

public class Translation
{
    [JsonPropertyName("homepage")]
    public string Homepage { get; set; }

    [JsonPropertyName("overview")]
    public string Overview { get; set; }

    [JsonPropertyName("runtime")]
    public long Runtime { get; set; }

    [JsonPropertyName("tagline")]
    public string Tagline { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }
}