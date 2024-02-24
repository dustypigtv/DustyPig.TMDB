using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.TvEpisode;

public class ChangeList
{
    [JsonPropertyName("changes")]
    public List<Change> Changes { get; set; } = [];
}
