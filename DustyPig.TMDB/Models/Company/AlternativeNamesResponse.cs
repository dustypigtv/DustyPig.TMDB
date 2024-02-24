using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Company;

public class AlternativeNamesResponse
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }
}