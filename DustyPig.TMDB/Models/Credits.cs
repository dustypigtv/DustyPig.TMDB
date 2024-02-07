using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models
{
    public class Credits
    {
        public List<Cast> Cast { get; set; }

        public List<Crew> Crew { get; set; }

        [JsonPropertyName("guest_stars")]
        public List<Cast> GuestStars { get; set; }
    }
}
