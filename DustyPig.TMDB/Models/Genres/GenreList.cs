using DustyPig.TMDB.Models.Common;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Genres;

public class GenreList
{
    [JsonPropertyName("genres")]
    public List<CommonName> Genres { get; set; } = [];
}
