using DustyPig.TMDB.Models.Common;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Movies;

public class AlternativeTitle
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("titles")]
    public List<CommonTitle> Titles { get; set; } = [];
}
