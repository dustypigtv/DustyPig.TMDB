using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Find;

public class ByIdResponse
{
    [JsonPropertyName("movie_results")]
    public List<MovieResultsObject> MovieResults { get; set; } = [];
}
