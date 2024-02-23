using DustyPig.TMDB.JsonHelpers;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.TvEpisode;

public class ChangesResponse
{
    [JsonPropertyName("changes")]
    public List<ChangesObject> Changes { get; set; } = [];
}
