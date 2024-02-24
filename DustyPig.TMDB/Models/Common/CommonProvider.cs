using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Common;

public class CommonProvider
{
    [JsonPropertyName("logo_path")]
    public string LogoPath { get; set; }

    [JsonPropertyName("provider_id")]
    public int ProviderId { get; set; }

    [JsonPropertyName("provider_name")]
    public string ProviderName { get; set; }

    [JsonPropertyName("display_priority")]
    public int DisplayPriority { get; set; }
}