using DustyPig.TMDB.Models.Common;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.People;

public class Cast : CommonMedia
{
    [JsonPropertyName("character")]
    public string Character { get; set; }

    [JsonPropertyName("credit_id")]
    public string CreditId { get; set; }

    /// <summary>
    /// Specific to <see cref="MediaType"/> == <see cref="CommonMediaTypes.Movie"/>
    /// </summary>
    [JsonPropertyName("order")]
    public int? Order { get; set; }

    /// <summary>
    /// Specific to <see cref="MediaType"/> == <see cref="CommonMediaTypes.TvSeries"/>
    /// </summary>
    [JsonPropertyName("episode_count")]
    public int? EpisodeCount { get; set; }
}