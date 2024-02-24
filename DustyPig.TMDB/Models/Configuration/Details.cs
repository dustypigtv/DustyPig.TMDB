using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Configuration;

public class Details
{
    [JsonPropertyName("images")]
    public Images Images { get; set; }

    [JsonPropertyName("change_keys")]
    public List<string> ChangeKeys { get; set; } = [];
}
