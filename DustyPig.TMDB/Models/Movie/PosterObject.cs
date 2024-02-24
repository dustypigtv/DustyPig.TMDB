﻿using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Movie;

public class PosterObject
{
    [JsonPropertyName("file_path")]
    public string FilePath { get; set; }

    /// <summary>
    /// ISO-639-1 2 letter language code. E.g. &quot;en&quot;
    /// </summary>
    [JsonPropertyName("iso_639_1")]
    public string LanguageCode { get; set; }
}