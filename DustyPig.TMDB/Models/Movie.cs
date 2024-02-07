using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models
{
    public class Movie
    {
        public List<Genre> Genres { get; set; } = [];

        public int Id { get; set; }

        public string Overview { get; set; }

        [JsonPropertyName("poster_path")]
        public string PosterPath { get; set; }

        [JsonPropertyName("backdrop_path")]
        public string BackdropPath { get; set; }

        [JsonPropertyName("release_date")]
        [JsonConverter(typeof(EmptyStringDateTimeConverter))]
        public DateTime? ReleaseDate { get; set; }

        public string Title { get; set; }

        public Credits Credits { get; set; }

        public Releases Releases { get; set; }

        public double Popularity { get; set; }
    }
}
