using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models;

public class PagedResultWithDates<T> : PagedResult<T>
{
    [JsonPropertyName("dates")]
    public DateRange Dates { get; set; }
}
