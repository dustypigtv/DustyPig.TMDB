using DustyPig.TMDB.JsonHelpers;
using DustyPig.TMDB.Models.Common;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.People;

public class Latest : ModelBase
{
    [JsonPropertyName("adult")]
    public bool Adult { get; set; }

    [JsonPropertyName("also_known_as")]
    public List<string> AlsoKnownAs { get; set; } = [];

    [JsonPropertyName("birthday")]
    [JsonConverter(typeof(StringToDateOnlyConverter))]
    public DateOnly? Birthday { get; set; }

    [JsonPropertyName("deathday")]
    [JsonConverter(typeof(StringToDateOnlyConverter))]
    public DateOnly? Deathday { get; set; }

    [JsonPropertyName("homepage")]
    public string HomePage { get; set; }

    [JsonPropertyName("biography")]
    public string Biography { get; set; }

    [JsonPropertyName("gender")]
    public Gender Gender { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("popularity")]
    public float Popularity { get; set; }

    [JsonPropertyName("imdb_id")]
    public string ImdbId { get; set; }

    [JsonPropertyName("known_for_department")]
    public string KnownForDepartment { get; set; }

    [JsonPropertyName("place_of_birth")]
    public string PlaceOfBirth { get; set; }

    [JsonPropertyName("profile_path")]
    public string ProfilePath { get; set; }
}
