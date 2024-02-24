using System.Collections.Generic;
using System.Text.Json.Serialization;
using DustyPig.TMDB.Models.Common;

namespace DustyPig.TMDB.Models.Movie;

public class ImagesResponse
{
    [JsonPropertyName("backdrops")]
    public List<BackdropObject> Backdrops { get; set; } = [];

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("logos")]
    public List<PosterObject> Logos { get; set; } = [];

    [JsonPropertyName("posters")]
    public List<PosterObject> Posters { get; set; } = [];
}
