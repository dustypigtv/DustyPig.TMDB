using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Person;

public class Change
{
    [JsonPropertyName("key")]
    public string Key { get; set; }

    [JsonPropertyName("items")]
    public List<Item> Items { get; set; } = [];
}