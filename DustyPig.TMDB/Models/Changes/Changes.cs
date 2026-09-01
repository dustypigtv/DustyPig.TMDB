using DustyPig.TMDB.Models.Common;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Changes;

public class Changes : ModelBase
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("adult")]
    public bool? Adult { get; set; }

    [JsonPropertyName("softcore")]
    public bool? SoftCore { get; set; }
}