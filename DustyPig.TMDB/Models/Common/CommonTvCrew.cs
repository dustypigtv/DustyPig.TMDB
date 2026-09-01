using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Common;

public class CommonTvCrew : CommonCrew
{
    [JsonPropertyName("total_episode_count")]
    public int TotalEpisodeCount { get; set; }

    [JsonPropertyName("jobs")]
    public List<CommonJob> Jobs { get; set; } = [];
}