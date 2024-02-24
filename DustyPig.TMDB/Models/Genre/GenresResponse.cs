using DustyPig.TMDB.Models.Common;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Genre;

public class GenresResponse
{
    [JsonPropertyName("genres")]
    public List<NameObject> Genres { get; set; } = [];
}
