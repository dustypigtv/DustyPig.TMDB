using DustyPig.TMDB.Models.Common;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.People;

public class Images
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("profiles")]
    public List<CommonPoster1> Profiles { get; set; } = [];
}
