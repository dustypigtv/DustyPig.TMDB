using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models
{
    internal class InternalPersonCreditBase
    {
        public int Id { get; set; }

        [JsonPropertyName("poster_path")]
        public string PosterPath { get; set; }

        [JsonPropertyName("backdrop_path")]
        public string BackdropPath { get; set; }

        public string Overview { get; set; }

        public double Popularity { get; set; }

    }
}
