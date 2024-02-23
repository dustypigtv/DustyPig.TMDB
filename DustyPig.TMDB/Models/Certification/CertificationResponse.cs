using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Certification;

public class CertificationResponse
{
    [JsonPropertyName("certifications")]
    public Dictionary<string, List<CertificationObject>> Certifications { get; set; } = [];
}
