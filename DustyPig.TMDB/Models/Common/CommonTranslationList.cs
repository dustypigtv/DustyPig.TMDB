using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Common;

public class CommonTranslationList<T> : ModelBase
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("translations")]
    public List<CommonTranslation<T>> Translations { get; set; } = [];
}