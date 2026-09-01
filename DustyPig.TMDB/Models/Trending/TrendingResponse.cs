using DustyPig.TMDB.Models.Common;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Trending;

public class TrendingResponse : ModelBase
{
    [JsonPropertyName("page")]
    public int Page { get; set; }

    [JsonPropertyName("total_pages")]
    public int TotalPages { get; set; }

    [JsonPropertyName("total_results")]
    public int TotalResults { get; set; }

    public List<Movie> Movies { get; set; } = [];

    public List<Series> Series { get; set; } = [];

    public List<Person> People { get; set; } = [];
}
