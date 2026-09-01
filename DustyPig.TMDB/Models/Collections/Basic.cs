using DustyPig.TMDB.Models.Common;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Collections;

public class Basic : ModelBase
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("poster_path")]
    public string PosterPath { get; set; }

    [JsonPropertyName("backdrop_path")]
    public string BackdropPath { get; set; }
}
