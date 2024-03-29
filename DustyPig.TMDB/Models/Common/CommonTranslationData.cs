﻿using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Common;

public class CommonTranslationData
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("overview")]
    public string Overview { get; set; }
}