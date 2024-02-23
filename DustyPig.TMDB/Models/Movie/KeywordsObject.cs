using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Movie;

public class KeywordsObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }
}