using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models
{
    internal class InternalPerson
    {
        public int Id { get; set; }

        public string Name { get; set; }


        [JsonConverter(typeof(EmptyStringDateTimeConverter))]
        public DateTime? Birthday { get; set; }


        [JsonConverter(typeof(EmptyStringDateTimeConverter))]
        public DateTime? Deathday { get; set; }

        public string Biography { get; set; }

        [JsonPropertyName("profile_path")]
        public string ProfilePath { get; set; }

        [JsonPropertyName("movie_credits")]
        public InternalPersonCreditsDiscriminator<InternalMovieCredit> MovieCredits { get; set; }

        [JsonPropertyName("tv_credits")]
        public InternalPersonCreditsDiscriminator<InternalTVCredit> TVCredits { get; set; }
    }
}
