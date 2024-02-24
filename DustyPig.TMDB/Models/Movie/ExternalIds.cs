using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Movie;

public class ExternalIds
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("imdb_id")]
    public string ImdbId { get; set; }

    [JsonPropertyName("facebook_id")]
    public string FacebookId { get; set; }
}
