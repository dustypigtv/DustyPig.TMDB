using DustyPig.TMDB.Models.Common;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Authentication;

public class CreateSessionRequest : ModelBase
{
    [JsonPropertyName("request_token")]
    public string RequestToken { get; set; }
}
