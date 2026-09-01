using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Common;

public class Job_ : ModelBase
{
    [JsonPropertyName("credit_id")]
    public string CreditId { get; set; }

    [JsonPropertyName("job")]
    public string Job { get; set; }

    [JsonPropertyName("episode_count")]
    public int EpisodeCount { get; set; }
}