using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Common;

public class CommonAccountState : ModelBase
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("favorite")]
    public bool Favorite { get; set; }

    [JsonPropertyName("rated")]
    public CommonRated Rated { get; set; }

    [JsonPropertyName("watchlist")]
    public bool Watchlist { get; set; }
}
