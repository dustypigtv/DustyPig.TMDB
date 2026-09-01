using DustyPig.TMDB.Enums;
using DustyPig.TMDB.JsonHelpers;
using System;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Common;

public class Movie : Media
{
    public Movie()
    {
        //Default
        MediaType = MediaTypes.Movie;
    }

    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("original_title")]
    public string OriginalTitle { get; set; }

    [JsonPropertyName("release_date")]
    [JsonConverter(typeof(StringToDateOnlyConverter))]
    public DateOnly? ReleaseDate { get; set; }

    [JsonPropertyName("video")]
    public bool? Video { get; set; }
}
