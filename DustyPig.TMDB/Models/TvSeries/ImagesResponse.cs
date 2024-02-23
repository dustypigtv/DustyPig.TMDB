using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.TvSeries;

public class ImagesResponse
{
    [JsonPropertyName("backdrops")]
    public List<BackdropsObject> Backdrops { get; set; } = [];

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("logos")]
    public List<LogosObject> Logos { get; set; } = [];

    [JsonPropertyName("posters")]
    public List<PostersObject> Posters { get; set; } = [];
}
