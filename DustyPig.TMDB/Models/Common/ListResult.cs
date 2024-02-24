using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Common;

public class ListResult<T>
{
    [JsonPropertyName("results")]
    public List<T> Results { get; set; } = [];
}