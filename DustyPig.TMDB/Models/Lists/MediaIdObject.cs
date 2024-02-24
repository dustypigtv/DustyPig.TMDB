using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Lists;

public class MediaIdObject
{
    [JsonPropertyName("media_id")]
    public int MediaId { get; set; }
}
