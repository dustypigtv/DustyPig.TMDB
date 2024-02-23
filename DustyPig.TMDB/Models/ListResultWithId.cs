using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models;

public class ListResultWithId<T> : ListResult<T>
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
}