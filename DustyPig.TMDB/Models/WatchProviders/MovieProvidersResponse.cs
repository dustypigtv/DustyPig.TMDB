using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.WatchProviders;

public class MovieProvidersResponse
{
    [JsonPropertyName("display_priorities")]
    public Dictionary<string, int> DisplayPriorities { get; set; } = [];

    [JsonPropertyName("display_priority")]
    public int DisplayPriority { get; set; }

    [JsonPropertyName("logo_path")]
    public string LogoPath { get; set; }

    [JsonPropertyName("provider_name")]
    public string ProviderName { get; set; }

    [JsonPropertyName("provider_id")]
    public int ProviderId { get; set; }
}