using DustyPig.TMDB.Models.Common;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.TvSeason;

public class ImagesResponse
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("posters")]
    public List<CommonPoster> Posters { get; set; } = [];
}
