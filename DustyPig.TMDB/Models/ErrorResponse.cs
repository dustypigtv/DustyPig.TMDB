using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models
{
    public class ErrorResponse
    {
        public bool Success { get; set; }

        [JsonPropertyName("status_code")]
        public long StatusCode { get; set; }

        [JsonPropertyName("status_message")]
        public string StatusMessage { get; set; }
    }
}
