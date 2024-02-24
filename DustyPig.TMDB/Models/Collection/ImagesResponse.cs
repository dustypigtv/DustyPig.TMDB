using DustyPig.TMDB.Models.Common;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Collection;

public class ImagesResponse
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("backdrops")]
    public List<CommonBackdrop> Backdrops { get; set; } = [];

    [JsonPropertyName("posters")]
    public List<CommonPoster> Posters { get; set; } = [];
}
