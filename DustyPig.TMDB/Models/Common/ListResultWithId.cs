using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Common;

public class ListResultWithId<T> : ListResult<T>
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
}