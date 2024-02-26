using DustyPig.TMDB.Models.Common;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.People;

public class Latest
{
    [JsonPropertyName("adult")]
    public bool Adult { get; set; }

    [JsonPropertyName("biography")]
    public string Biography { get; set; }

    [JsonPropertyName("gender")]
    public CommonGender Gender { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("popularity")]
    public float Popularity { get; set; }
}
