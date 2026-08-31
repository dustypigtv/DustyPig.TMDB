using DustyPig.TMDB.Models.Common;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Certifications;

public class CertificationsList : ModelBase
{
    [JsonPropertyName("certifications")]
    public Dictionary<string, List<CertificationObject>> Certifications { get; set; } = [];
}
