using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Common;

public class Name_ : ModelBase
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }
}