using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Common;

public class CommonStatus : ModelBase
{
    [JsonPropertyName("success")]
    public bool Success { get; set; }

    [JsonPropertyName("status_code")]
    public int StatusCode { get; set; }

    [JsonPropertyName("status_message")]
    public string StatusMessage { get; set; }
}
