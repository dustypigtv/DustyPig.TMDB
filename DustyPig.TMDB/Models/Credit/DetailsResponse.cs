using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Credit;

public class DetailsResponse
{
    [JsonPropertyName("credit_type")]
    public string CreditType { get; set; }

    [JsonPropertyName("department")]
    public string Department { get; set; }

    [JsonPropertyName("job")]
    public string Job { get; set; }

    [JsonPropertyName("media")]
    public MediaObject Media { get; set; }

    [JsonPropertyName("media_type")]
    public string MediaType { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("person")]
    public PersonObject Person { get; set; }
}
