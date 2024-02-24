using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Collection;

public class TranslationData
{
    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("overview")]
    public string Overview { get; set; }

    [JsonPropertyName("homepage")]
    public string Homepage { get; set; }
}