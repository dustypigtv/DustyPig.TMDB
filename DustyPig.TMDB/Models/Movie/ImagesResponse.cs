using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Movie;

public class ImagesResponse
{
    [JsonPropertyName("backdrops")]
    public List<BackdropsObject> Backdrops { get; set; } = [];

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("logos")]
    public List<PosterObject2> Logos { get; set; } = [];

    [JsonPropertyName("posters")]
    public List<PosterObject2> Posters { get; set; } = [];
}
