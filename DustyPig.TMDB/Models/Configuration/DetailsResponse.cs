using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Configuration;

public class DetailsResponse
{
    [JsonPropertyName("images")]
    public ImagesObject Images { get; set; }

    [JsonPropertyName("change_keys")]
    public List<string> ChangeKeys { get; set; } = [];
}
