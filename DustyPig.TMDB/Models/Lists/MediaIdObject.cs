using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Lists;

internal class MediaIdObject
{
    public MediaIdObject() { }

    public MediaIdObject(int mediaId) => MediaId = mediaId;

    [JsonPropertyName("media_id")]
    public int MediaId { get; set; }
}
