using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Certification;

public class CertificationObject
{
    [JsonPropertyName("certification")]
    public string Certification { get; set; }

    [JsonPropertyName("meaning")]
    public string Meaning { get; set; }

    [JsonPropertyName("order")]
    public int Order { get; set; }
}