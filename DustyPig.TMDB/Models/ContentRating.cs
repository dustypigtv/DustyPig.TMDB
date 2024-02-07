using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models
{
    public class ContentRating
    {
        [JsonPropertyName("iso_3166_1")]
        public string Country { get; set; }

        public string Rating { get; set; }
    }
}
