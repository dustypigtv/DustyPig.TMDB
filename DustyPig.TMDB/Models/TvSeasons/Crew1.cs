﻿using DustyPig.TMDB.Models.Common;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.TvSeasons;

public class Crew1
{
    [JsonPropertyName("adult")]
    public bool Adult { get; set; }

    [JsonPropertyName("gender")]
    public CommonGender Gender { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("known_for_department")]
    public string KnownForDepartment { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("original_name")]
    public string OriginalName { get; set; }

    [JsonPropertyName("popularity")]
    public float Popularity { get; set; }

    [JsonPropertyName("jobs")]
    public List<CommonJob> Jobs { get; set; } = [];

    [JsonPropertyName("department")]
    public string Department { get; set; }

    [JsonPropertyName("total_episode_count")]
    public int TotalEpisodeCount { get; set; }
}