using DustyPig.TMDB.Models.Common;
using DustyPig.TMDB.Models.TvEpisodeGroups;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Find;

public class FindResult : ModelBase
{
    [JsonPropertyName("movie_results")]
    public List<CommonMedia> MovieResults { get; set; } = [];

    [JsonPropertyName("tv_results")]
    public List<CommonMedia> TvResults { get; set; } = [];

    [JsonPropertyName("tv_season_results")]
    public List<FindSeasonResult> TvSeasonResults { get; set; } = [];

    [JsonPropertyName("tv_episode_results")]
    public List<Episode> TvEpisodeResults { get; set; } = [];

    [JsonPropertyName("person_results")]
    public List<FindPersonResult> PersonResults { get; set; } = [];
}
