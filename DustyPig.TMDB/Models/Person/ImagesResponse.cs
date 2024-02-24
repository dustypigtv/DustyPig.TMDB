using System.Collections.Generic;
using System.Text.Json.Serialization;
using DustyPig.TMDB.Models.Common;

namespace DustyPig.TMDB.Models.Person;

public class ImagesResponse
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("profiles")]
    public List<PosterObject> Profiles { get; set; } = [];
}
