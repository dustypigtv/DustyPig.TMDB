using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Search;

public class KeywordResponse
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }
}