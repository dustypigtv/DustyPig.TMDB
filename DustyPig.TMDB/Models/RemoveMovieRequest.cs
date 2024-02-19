using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models;

public class RemoveMovieRequest
{
    [JsonPropertyName("media_id")]
    public int MediaId { get; set; }
}
