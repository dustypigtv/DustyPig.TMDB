using DustyPig.TMDB.Models.Common;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.People;

public class Crew : CommonMedia
{
    [JsonPropertyName("credit_id")]
    public string CreditId { get; set; }

    [JsonPropertyName("department")]
    public string Department { get; set; }

    [JsonPropertyName("job")]
    public string Job { get; set; }

    /// <summary>
    /// Specific to <see cref="MediaType"/> == <see cref="CommonMediaTypes.TvSeries"/>
    /// </summary>
    [JsonPropertyName("episode_count")]
    public int? EpisodeCount { get; set; }
}