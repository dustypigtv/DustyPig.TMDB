using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models
{
    public class Release
    {
        [JsonPropertyName("certification")]
        public string Rating { get; set; }

        public string Country { get; set; }
    }
}
