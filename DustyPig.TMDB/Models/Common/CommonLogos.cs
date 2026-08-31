using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Common;

public class CommonLogos : ModelBase
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("logos")]
    public List<CommonLogo> Logos { get; set; } = [];
}
