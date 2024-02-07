using System;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models
{
    public class Country : IComparable<Country>
    {
        public string Certification { get; set; }

        [JsonPropertyName("iso_3166_1")]
        public string Name { get; set; }

        [JsonPropertyName("release_date")]
        public DateTime ReleaseDate { get; set; }

        public int CompareTo(Country other)
        {
            return ReleaseDate.CompareTo(other.ReleaseDate);
        }
    }
}
