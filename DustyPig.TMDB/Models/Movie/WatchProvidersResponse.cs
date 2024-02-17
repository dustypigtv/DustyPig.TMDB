using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Movie;

public class WatchProvidersResponse
{
    public class Providers
    {
        public class Provider
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


    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("results")]
    public Dictionary<string, List<Providers>> Results { get; set; }
}
