using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Movie;

public class ChangesResponse
{
    [JsonPropertyName("changes")]
    public List<ChangesObject> Changes { get; set; } = [];
}
