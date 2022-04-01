using Newtonsoft.Json;

namespace DustyPig.TMDB.Models
{
    public class ContentRating
    {
        [JsonProperty("iso_3166_1")]
        public string Country { get; set; }

        public string Rating { get; set; }
    }
}
