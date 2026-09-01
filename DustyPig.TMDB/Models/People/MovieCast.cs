using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.People;

public class MovieCast : Movie
{
    [JsonPropertyName("character")]
    public string Character { get; set; }

    [JsonPropertyName("credit_id")]
    public string CreditId { get; set; }

    [JsonPropertyName("order")]
    public int? Order { get; set; }
}
