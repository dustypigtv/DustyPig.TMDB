using Newtonsoft.Json;
using System;

namespace DustyPig.TMDB.Models
{
    public class Country
    {
        public string Certification { get; set; }

        [JsonProperty("iso_3166_1")]
        public string Name { get; set; }

        [JsonProperty("release_date")]
        public DateTime ReleaseDate { get; set; }
    }
}
