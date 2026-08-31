using DustyPig.TMDB.Models.Common;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Collections;

public class Images : ModelBase
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("backdrops")]
    public List<CommonImage> Backdrops { get; set; } = [];

    [JsonPropertyName("posters")]
    public List<CommonImage> Posters { get; set; } = [];
}
