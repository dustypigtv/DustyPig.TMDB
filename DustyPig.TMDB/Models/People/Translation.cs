using DustyPig.TMDB.Models.Common;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.People;

public class Translation : CommonTranslationData
{
    [JsonPropertyName("biography")]
    public string Biography { get; set; }

    [JsonPropertyName("primary")]
    public bool Primary { get; set; }
}