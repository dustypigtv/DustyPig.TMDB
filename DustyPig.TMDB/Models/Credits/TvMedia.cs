using DustyPig.TMDB.Models.Common;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Credits;

public class TvMedia : Common.TvSeries
{
    [JsonPropertyName("character")]
    public string Character { get; set; }

    [JsonPropertyName("seasons")]
    public List<Season> Seasons { get; set; } = [];

    [JsonPropertyName("episodes")]
    public List<Episode> Episodes { get; set; } = [];
}
