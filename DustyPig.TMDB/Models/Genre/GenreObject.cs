using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Genre;

public class GenreObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }
}