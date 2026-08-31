using DustyPig.TMDB.Models.Common;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.TvEpisodes;

public class ChangeList : ModelBase
{
    [JsonPropertyName("changes")]
    public List<Change> Changes { get; set; } = [];
}
