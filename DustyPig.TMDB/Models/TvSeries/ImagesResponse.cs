using DustyPig.TMDB.Models.Common;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.TvSeries;

public class ImagesResponse
{
    [JsonPropertyName("backdrops")]
    public List<CommonBackdrop> Backdrops { get; set; } = [];

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("logos")]
    public List<PosterObject> Logos { get; set; } = [];

    [JsonPropertyName("posters")]
    public List<PosterObject> Posters { get; set; } = [];
}
