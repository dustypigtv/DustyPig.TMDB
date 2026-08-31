using DustyPig.TMDB.Models.Common;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Authentication;

public class DeleteSessionRequest : ModelBase
{
    [JsonPropertyName("session_id")]
    public string SessionId { get; set; }
}
