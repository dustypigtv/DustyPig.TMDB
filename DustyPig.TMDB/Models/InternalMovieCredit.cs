using System;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models
{
    internal class InternalMovieCredit : InternalPersonCreditBase
    {
        public string Title { get; set; }

        [JsonPropertyName("release_date")]
        [JsonConverter(typeof(EmptyStringDateTimeConverter))]
        public DateTime? ReleaseDate { get; set; }
    }
}
