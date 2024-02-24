﻿using DustyPig.TMDB.JsonHelpers;
using System.Text.Json.Serialization;
using System;

namespace DustyPig.TMDB.Models.Movie;

public class ReleaseDatesObject
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