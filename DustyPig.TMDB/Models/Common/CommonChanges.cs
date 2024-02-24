using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Common;

public class CommonChanges
{
    [JsonPropertyName("changes")]
    public List<CommonChange> Changes { get; set; } = [];
}
