using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.TvSeason;

public class WatchProvidersResponse
{
    [JsonPropertyName("ads")]
    public List<ProviderObject> Ads { get; set; } = [];

    [JsonPropertyName("buy")]
    public List<ProviderObject> Buy { get; set; } = [];

    [JsonPropertyName("flatrate")]
    public List<ProviderObject> Flatrate { get; set; } = [];

    [JsonPropertyName("free")]
    public List<ProviderObject> Free { get; set; } = [];

    [JsonPropertyName("link")]
    public string Link { get; set; }

    [JsonPropertyName("rent")]
    public List<ProviderObject> Rent { get; set; } = [];
}