using System.Collections.Generic;
using System.Text.Json.Serialization;
using DustyPig.TMDB.Models.Common;

namespace DustyPig.TMDB.Models.Collection;

public class ImagesResponse
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("backdrops")]
    public List<BackdropObject> Backdrops { get; set; } = [];

    [JsonPropertyName("posters")]
    public List<PosterObject> Posters { get; set; } = [];
}
