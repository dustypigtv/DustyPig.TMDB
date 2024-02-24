using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Common;

public class CommonWatchProvider
{
    [JsonPropertyName("ads")]
    public List<CommonProvider> Ads { get; set; } = [];

    [JsonPropertyName("buy")]
    public List<CommonProvider> Buy { get; set; } = [];

    [JsonPropertyName("flatrate")]
    public List<CommonProvider> Flatrate { get; set; } = [];

    [JsonPropertyName("free")]
    public List<CommonProvider> Free { get; set; } = [];

    [JsonPropertyName("link")]
    public string Link { get; set; }

    [JsonPropertyName("rent")]
    public List<CommonProvider> Rent { get; set; } = [];
}