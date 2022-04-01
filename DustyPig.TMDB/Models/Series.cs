using Newtonsoft.Json;
using System.Collections.Generic;

namespace DustyPig.TMDB.Models
{
    public class Series
    {
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Title { get; set; }

        public List<Genre> Genres { get; set; } = new List<Genre>();

        public Credits Credits { get; set; }

        public string Overview { get; set; }

        [JsonProperty("poster_path")]
        public string PosterPath { get; set; }

        [JsonProperty("content_ratings")]
        public ContentRatings ContentRatings { get; set; }

        public double Popularity { get; set; }
    }
}
