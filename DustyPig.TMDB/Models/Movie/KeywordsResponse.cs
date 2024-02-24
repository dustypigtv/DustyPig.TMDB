using DustyPig.TMDB.Models.Common;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Movie;

public class KeywordsResponse
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("keywords")]
    public List<CommonName> Keywords { get; set; } = [];
}
