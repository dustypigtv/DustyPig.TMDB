using DustyPig.TMDB.Models.Common;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Credits;

public class Media : CommonMedia
{
    [JsonPropertyName("character")]
    public string Character { get; set; }

    [JsonPropertyName("seasons")]
    public List<Season> Seasons { get; set; } = [];
}