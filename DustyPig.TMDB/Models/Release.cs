using Newtonsoft.Json;

namespace DustyPig.TMDB.Models
{
    public class Release
    {
        [JsonProperty("certification")]
        public string Rating { get; set; }

        public string Country { get; set; }
    }
}
