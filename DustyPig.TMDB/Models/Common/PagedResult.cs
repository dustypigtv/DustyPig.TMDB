using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Common;

public class PagedResult<T> : ListResult<T>
{
    [JsonPropertyName("page")]
    public int Page { get; set; }

    [JsonPropertyName("total_pages")]
    public int TotalPages { get; set; }

    [JsonPropertyName("total_results")]
    public int TotalResults { get; set; }
}