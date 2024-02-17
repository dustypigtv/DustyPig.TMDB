using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.TvSeries;

public class AlternativeTitlesResponse
{
    public class ResultsObject
    {
        /// <summary>
        /// ISO-3166-1 2 letter country code. E.g. &quot;US&quot;
        /// </summary>
        [JsonPropertyName("iso_3166_1")]
        public string CountryCode { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }
    }


    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("results")]
    public List<ResultsObject> Results { get; set; } = [];
}
