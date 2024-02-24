using DustyPig.TMDB.Models.Common;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.TvSeasons;

public class Images
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("posters")]
    public List<CommonPoster1> Posters { get; set; } = [];
}
