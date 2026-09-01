using DustyPig.TMDB.Models.Common;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Genres;

public class GenreList : ModelBase
{
    [JsonPropertyName("genres")]
    public List<NameObject> Genres { get; set; } = [];
}
