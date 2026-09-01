using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Common;

public class Images : ModelBase
{
    [JsonPropertyName("backdrops")]
    public List<Image> Backdrops { get; set; } = [];

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("logos")]
    public List<Image> Logos { get; set; } = [];

    [JsonPropertyName("posters")]
    public List<Image> Posters { get; set; } = [];

    [JsonPropertyName("profiles")]
    public List<Image> Profiles { get; set; } = [];

    [JsonPropertyName("stills")]
    public List<Image> Stills { get; set; } = [];
}
