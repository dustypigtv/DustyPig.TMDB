using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Changes;

public class ChangesResponse
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("adult")]
    public bool Adult { get; set; }
}