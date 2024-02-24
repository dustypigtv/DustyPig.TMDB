using DustyPig.TMDB.Models.Common;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Movies;

public class KeywordsList
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("keywords")]
    public List<CommonName> Keywords { get; set; } = [];
}
