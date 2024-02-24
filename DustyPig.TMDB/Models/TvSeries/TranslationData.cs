using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.TvSeries;

public class TranslationData
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("overview")]
    public string Overview { get; set; }

    [JsonPropertyName("homepage")]
    public string Homepage { get; set; }

    [JsonPropertyName("tagline")]
    public string Tagline { get; set; }
}