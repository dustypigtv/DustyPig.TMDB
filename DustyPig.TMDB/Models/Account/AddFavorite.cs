using DustyPig.TMDB.JsonHelpers;
using DustyPig.TMDB.Models.Common;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Account;

public class AddFavorite
{
    [JsonPropertyName("media_type")]
    [JsonConverter(typeof(MediaTypesConverter))]
    public MediaTypes MediaType { get; set; }

    [JsonPropertyName("media_id")]
    public int MediaId { get; set; }

    [JsonPropertyName("favorite")]
    public bool Favorite { get; set; }
}
