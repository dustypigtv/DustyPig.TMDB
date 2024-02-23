using DustyPig.TMDB.JsonHelpers;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.TvSeason;

public class AccountStatesResponse
{
    public class ResultsObject
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("episode_number")]
        public int EpisodeNumber { get; set; }

        [JsonPropertyName("rated")]
        [JsonConverter(typeof(RatedConverter))]
        public float? Rated { get; set; }

    }


    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("results")]
    public List<ResultsObject> Results { get; set; } = [];
}
