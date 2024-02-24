using DustyPig.TMDB.JsonHelpers;
using System;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Movie;

public class Release
{
    [JsonPropertyName("certification")]
    public string Certification { get; set; }

    /// <summary>
    /// ISO-639-1 2 letter language code. E.g. &quot;en&quot;
    /// </summary>
    [JsonPropertyName("iso_639_1")]
    public string LanguageCode { get; set; }

    [JsonPropertyName("note")]
    public string Note { get; set; }

    [JsonPropertyName("release_date")]
    [JsonConverter(typeof(StringToDateOnlyConverter))]
    public DateOnly? ReleaseDate { get; set; }

    [JsonPropertyName("type")]
    public int Type { get; set; }
}