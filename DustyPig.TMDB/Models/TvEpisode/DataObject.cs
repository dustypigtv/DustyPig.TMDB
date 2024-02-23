﻿using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.TvEpisode;

public class DataObject
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("overview")]
    public string Overview { get; set; }
}