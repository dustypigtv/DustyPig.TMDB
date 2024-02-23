using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Person;

public class DataObject
{
    [JsonPropertyName("biography")]
    public string Biography { get; set; }
}