﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Movie;

public class ChangesObject
{
    [JsonPropertyName("key")]
    public string Key { get; set; }

    [JsonPropertyName("items")]
    public List<ItemsObject> Items { get; set; } = [];
}