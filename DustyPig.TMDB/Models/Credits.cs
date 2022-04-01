using Newtonsoft.Json;
using System.Collections.Generic;

namespace DustyPig.TMDB.Models
{
    public class Credits
    {
        public List<Cast> Cast { get; set; } = new List<Cast>();

        public List<Crew> Crew { get; set; } = new List<Crew>();

        [JsonProperty("guest_stars")]
        public List<Cast> GuestStars { get; set; } = new List<Cast>();
    }
}
