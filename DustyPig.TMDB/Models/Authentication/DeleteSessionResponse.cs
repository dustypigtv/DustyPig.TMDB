using DustyPig.TMDB.Models.Common;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Authentication;

public class DeleteSessionResponse : ModelBase
{
    [JsonPropertyName("success")]
    public bool Success { get; set; }
}
