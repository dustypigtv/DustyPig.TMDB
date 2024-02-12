using System;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models
{
    internal class InternalTVCredit : InternalPersonCreditBase
    {
        public string Name { get; set; }

        [JsonPropertyName("first_air_date")]
        [JsonConverter(typeof(EmptyStringDateTimeConverter))]
        public DateTime? FirstAirDate { get; set; }
    }
}
