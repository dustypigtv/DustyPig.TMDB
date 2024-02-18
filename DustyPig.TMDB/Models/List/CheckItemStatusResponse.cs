using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.List;

public class CheckItemStatusResponse
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("item_present")]
    public bool ItemPresent { get; set; }
}
