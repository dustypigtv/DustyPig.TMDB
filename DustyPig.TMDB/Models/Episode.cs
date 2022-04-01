using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace DustyPig.TMDB.Models
{
    public class Episode
    {
        public int Id { get; set; }

        [JsonProperty("air_date")]
        public DateTime? AirDate { get; set; }

        public List<Crew> Crew { get; set; } = new List<Crew>();

        [JsonProperty("episode_number")]
        public int EpisodeNumber { get; set; }

        public string Name { get; set; }

        public string Overview { get; set; }

        [JsonProperty("season_number")]
        public int SeasonNumber { get; set; }

        [JsonProperty("still_path")]
        public string StillPath { get; set; }
    }
}
