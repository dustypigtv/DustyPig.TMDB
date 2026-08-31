using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Common;

public class CommonImages : ModelBase
{
    [JsonPropertyName("backdrops")]
    public List<CommonImage> Backdrops { get; set; } = [];

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("logos")]
    public List<CommonImage> Logos { get; set; } = [];

    [JsonPropertyName("posters")]
    public List<CommonImage> Posters { get; set; } = [];
}
