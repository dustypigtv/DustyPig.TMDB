using DustyPig.TMDB.Models.Common;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Certifications;

public class CertificationObject : ModelBase
{
    [JsonPropertyName("certification")]
    public string Certification { get; set; }

    [JsonPropertyName("meaning")]
    public string Meaning { get; set; }

    [JsonPropertyName("order")]
    public int Order { get; set; }
}