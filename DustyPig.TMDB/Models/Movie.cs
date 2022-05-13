using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace DustyPig.TMDB.Models
{
    public class Movie
    {
        public List<Genre> Genres { get; set; } = new List<Genre>();

        public int Id { get; set; }

        public string Overview { get; set; }

        [JsonProperty("poster_path")]
        public string PosterPath { get; set; }

        [JsonProperty("backdrop_path")]
        public string BackdropPath { get; set; }

        [JsonProperty("release_date")]
        public DateTime? ReleaseDate { get; set; }

        public string Title { get; set; }

        public Credits Credits { get; set; }

        public Releases Releases { get; set; }

        public double Popularity { get; set; }
    }
}
