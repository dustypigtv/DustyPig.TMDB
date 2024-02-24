using DustyPig.TMDB.Models.Common;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Authentication;

public class ValidateKey : CommonStatus
{
    [JsonPropertyName("success")]
    public bool Success { get; set; }
}
