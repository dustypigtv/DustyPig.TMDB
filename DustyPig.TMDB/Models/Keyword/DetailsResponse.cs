using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Keyword;

public class DetailsResponse
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }
}
