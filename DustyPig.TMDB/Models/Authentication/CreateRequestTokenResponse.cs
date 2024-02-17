using DustyPig.TMDB.JsonHelpers;
using System;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Authentication;

public class CreateRequestTokenResponse
{
    [JsonPropertyName("success")]
    public bool Success { get; set; }

    [JsonPropertyName("expires_at")]
    [JsonConverter(typeof(StringToDateTimeConverter))]
    public DateTime? ExpiresAt { get; set; }

    [JsonPropertyName("request_token")]
    public string RequestToken { get; set; }
}
