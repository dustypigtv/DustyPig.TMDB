using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.TvSeason;

public class AccountStatesResponse
{
    public class ResultsObject
    {
        public class RatedObject
        {
            [JsonPropertyName("value")]
            public int Value { get; set; }
        }


        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("episode_number")]
        public int EpisodeNumber { get; set; }

        [JsonPropertyName("rated")]
        public RatedObject Rated { get; set; }
    }


    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("results")]
    public List<ResultsObject> Results { get; set; } = [];
}
