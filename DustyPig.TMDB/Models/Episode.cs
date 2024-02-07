using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models
{
    public class Episode
    {
        public int Id { get; set; }

        [JsonPropertyName("air_date")]
        [JsonConverter(typeof(EmptyStringDateTimeConverter))]
        public DateTime? AirDate { get; set; }

        public List<Crew> Crew { get; set; }

        [JsonPropertyName("episode_number")]
        public int EpisodeNumber { get; set; }

        public string Name { get; set; }

        public string Overview { get; set; }

        [JsonPropertyName("season_number")]
        public int SeasonNumber { get; set; }

        [JsonPropertyName("still_path")]
        public string StillPath { get; set; }
    }
}
