using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Collection;

public class ImagesResponse
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("backdrops")]
    public List<BackdropsObject> Backdrops { get; set; } = [];

    [JsonPropertyName("posters")]
    public List<PostersObject> Posters { get; set; } = [];
}
