using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Common;

public class TranslationsResponse<T>
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("translations")]
    public List<T> Translations { get; set; } = [];
}