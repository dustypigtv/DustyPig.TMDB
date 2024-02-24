using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.TvSeries;

public class NameObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }
}