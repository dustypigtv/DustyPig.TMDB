using System.Collections.Generic;
using System.Text.Json.Serialization;
using DustyPig.TMDB.Models.Common;

namespace DustyPig.TMDB.Models.Genre;

public class GenresResponse
{
    [JsonPropertyName("genres")]
    public List<NameObject> Genres { get; set; } = [];
}
