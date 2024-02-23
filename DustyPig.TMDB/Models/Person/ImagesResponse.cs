using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Person;

public class ImagesResponse
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("profiles")]
    public List<ProfileObject> Profiles { get; set; } = [];
}
