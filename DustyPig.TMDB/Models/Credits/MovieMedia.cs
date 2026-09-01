using DustyPig.TMDB.Models.Common;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Credits;

public class MovieMedia : Movie
{
    [JsonPropertyName("character")]
    public string Character { get; set; }
}
