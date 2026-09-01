using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Common;

public class TvCrew : Crew
{
    [JsonPropertyName("total_episode_count")]
    public int TotalEpisodeCount { get; set; }

    [JsonPropertyName("jobs")]
    public List<Job_> Jobs { get; set; } = [];
}