using DustyPig.TMDB.JsonHelpers;
using System;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Authentication;

public class CreateGuestSessionResponse
{
    [JsonPropertyName("success")]
    public bool Success { get; set; }

    [JsonPropertyName("guest_session_id")]
    public string GuestSessionId { get; set; }

    [JsonPropertyName("expires_at")]
    [JsonConverter(typeof(StringToDateTimeConverter))]
    public DateTime? ExpiresAt { get; set; }
}
