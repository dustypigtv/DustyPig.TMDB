using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Networks;

public class Details
{
    [JsonPropertyName("headquarters")]
    public string Headquarters { get; set; }

    [JsonPropertyName("homepage")]
    public string Homepage { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("logo_path")]
    public string LogoPath { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("origin_country")]
    public string OriginCountry { get; set; }
}
