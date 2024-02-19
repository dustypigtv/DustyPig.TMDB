using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models;

public class AddToWatchlistRequest
{
    [JsonPropertyName("media_type")]
    public string MediaType { get; set; }

    [JsonPropertyName("media_id")]
    public int MediaId { get; set; }

    [JsonPropertyName("watchlist")]
    public bool Watchlist { get; set; }
}
