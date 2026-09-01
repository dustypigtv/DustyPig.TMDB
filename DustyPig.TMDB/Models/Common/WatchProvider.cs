using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Common;

public class WatchProvider : ModelBase
{
    [JsonPropertyName("ads")]
    public List<Provider> Ads { get; set; } = [];

    [JsonPropertyName("buy")]
    public List<Provider> Buy { get; set; } = [];

    [JsonPropertyName("flatrate")]
    public List<Provider> Flatrate { get; set; } = [];

    [JsonPropertyName("free")]
    public List<Provider> Free { get; set; } = [];

    [JsonPropertyName("link")]
    public string Link { get; set; }

    [JsonPropertyName("rent")]
    public List<Provider> Rent { get; set; } = [];
}