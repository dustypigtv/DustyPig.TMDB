using System;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models
{
    class InternalSearchResult
    {
        public int Id { get; set; }

        [JsonPropertyName("poster_path")]
        public string PosterPath { get; set; }

        [JsonPropertyName("backdrop_path")]
        public string BackdropPath { get; set; }

        [JsonPropertyName("release_date")]
        [JsonConverter(typeof(EmptyStringDateTimeConverter))]
        public DateTime? ReleaseDate { get; set; }

        // Movies return Title
        public string Title { get; set; }

        // Series returns Name
        public string Name { get; set; }

        [JsonPropertyName("media_type")]
        public string MediaType { get; set; }

        [JsonPropertyName("profile_path")]
        public string ProfilePath { get; set; }

    }
}
