using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Certification;

public class CertificationResponse
{
    public class CertificationObject
    {
        [JsonPropertyName("certification")]
        public string Certification { get; set; }

        [JsonPropertyName("meaning")]
        public string Meaning { get; set; }

        [JsonPropertyName("order")]
        public int Order { get; set; }
    }


    [JsonPropertyName("certifications")]
    public Dictionary<string, List<CertificationObject>> Certifications { get; set; } = [];
}
