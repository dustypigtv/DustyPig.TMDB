using Newtonsoft.Json;
using System;

namespace DustyPig.TMDB.Models
{
    class InternalSearchResult
    {
        public int Id { get; set; }

        [JsonProperty("poster_path")]
        public string PosterPath { get; set; }

        [JsonProperty("backdrop_path")]
        public string BackdropPath { get; set; }

        [JsonProperty("release_date")]
        public DateTime? ReleaseDate { get; set; }

        // Movies return Title
        public string Title { get; set; }

        // Series returns Name
        public string Name { get; set; }

        [JsonProperty("media_type")]
        public string MediaType { get; set; }
    }
}
