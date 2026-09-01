using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Common;

public  class CommonSuccessStatus : CommonStatus
{
    [JsonPropertyName("success")]
    public bool Success { get; set; }
}
