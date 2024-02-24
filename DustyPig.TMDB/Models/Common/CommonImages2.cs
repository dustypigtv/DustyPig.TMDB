using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Common;

public class CommonImages2
{
    [JsonPropertyName("backdrops")]
    public List<CommonBackdrop> Backdrops { get; set; } = [];

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("logos")]
    public List<CommonPoster2> Logos { get; set; } = [];

    [JsonPropertyName("posters")]
    public List<CommonPoster2> Posters { get; set; } = [];
}
