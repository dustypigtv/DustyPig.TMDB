using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Common;

public class ChangesList : ModelBase
{
    [JsonPropertyName("changes")]
    public List<Change> Changes { get; set; } = [];
}
