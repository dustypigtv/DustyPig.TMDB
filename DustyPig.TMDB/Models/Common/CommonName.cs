﻿using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Common;

public class CommonName
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }
}