using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Common;

public class PagedResultWithId<T> : PagedResult<T>
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
}