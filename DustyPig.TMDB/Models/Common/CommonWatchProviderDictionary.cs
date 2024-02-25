using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Common;

public class CommonWatchProviderDictionary
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("results")]
    public Dictionary<string, CommonWatchProvider> Result { get; set; } = [];
}