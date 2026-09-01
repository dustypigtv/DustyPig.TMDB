using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Common;

public class CommonTranslationData : ModelBase
{
    [JsonPropertyName("title")]
    public string ObjectTitle { get; set; }

    [JsonPropertyName("name")]
    public string ObjectName { get; set; }

    /// <summary>
    /// For movies, this is the 'title' property.
    /// For tv, this is the 'name' property.
    /// </summary>
    [JsonIgnore]
    public string Title => Utils.Coalesce(ObjectTitle, ObjectName);


    [JsonPropertyName("overview")]
    public string Overview { get; set; }

    [JsonPropertyName("homepage")]
    public string HomePage { get; set; }


    [JsonPropertyName("runtime")]
    public long Runtime { get; set; }

    [JsonPropertyName("tagline")]
    public string Tagline { get; set; }


}