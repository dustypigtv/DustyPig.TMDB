using DustyPig.TMDB.JsonHelpers;
using DustyPig.TMDB.Models.Common;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Credits;

public class Details
{
    [JsonPropertyName("credit_type")]
    public string CreditType { get; set; }

    [JsonPropertyName("department")]
    public string Department { get; set; }

    [JsonPropertyName("job")]
    public string Job { get; set; }

    [JsonPropertyName("media")]
    public Media Media { get; set; }

    [JsonPropertyName("media_type")]
    [JsonConverter(typeof(MediaTypesConverter))]
    public MediaTypes MediaType { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("person")]
    public Person Person { get; set; }
}
