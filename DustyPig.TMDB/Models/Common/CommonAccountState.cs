using DustyPig.TMDB.JsonHelpers;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Common;

public class CommonAccountState
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("favorite")]
    public bool Favorite { get; set; }

    [JsonPropertyName("rated")]
    [JsonConverter(typeof(RatedConverter))]
    public float? Rated { get; set; }

    [JsonPropertyName("watchlist")]
    public bool Watchlist { get; set; }
}
