using DustyPig.TMDB.Models.Common;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.TvEpisodes;

public class Images
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("stills")]
    public List<CommonBackdrop> Stills { get; set; } = [];
}
