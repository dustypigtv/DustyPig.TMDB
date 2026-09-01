using DustyPig.TMDB.JsonHelpers;
using DustyPig.TMDB.Models.Common;
using System;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models;

public class Movie : CommonMediaBase
{
    public Movie()
    {
        //Default
        MediaType = CommonMediaTypes.Movie;
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
