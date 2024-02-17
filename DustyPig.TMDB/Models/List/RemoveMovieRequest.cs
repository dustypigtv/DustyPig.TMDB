using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.List;

public class RemoveMovieRequest
{
    [JsonPropertyName("media_id")]
    public int MediaId { get; set; }
}
