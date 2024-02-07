using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models
{
    public class Series
    {
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Title { get; set; }

        public List<Genre> Genres { get; set; }

        public Credits Credits { get; set; }

        public string Overview { get; set; }

        [JsonPropertyName("poster_path")]
        public string PosterPath { get; set; }

        [JsonPropertyName("backdrop_path")]
        public string BackdropPath { get; set; }

        [JsonPropertyName("content_ratings")]
        public ContentRatings ContentRatings { get; set; }

        public double Popularity { get; set; }

        [JsonPropertyName("first_air_date")]
        [JsonConverter(typeof(EmptyStringDateTimeConverter))]
        public DateTime? FirstAirDate { get; set; }
    }
}
