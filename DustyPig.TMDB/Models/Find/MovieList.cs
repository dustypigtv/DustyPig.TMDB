using DustyPig.TMDB.Models.Common;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Find;

public class MovieList
{
    [JsonPropertyName("movie_results")]
    public List<CommonMedia> MovieResults { get; set; } = [];
}
