using DustyPig.TMDB.JsonHelpers;
using DustyPig.TMDB.Models.Common;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.People;

public class Details
{
    [JsonPropertyName("adult")]
    public bool Adult { get; set; }

    [JsonPropertyName("also_known_as")]
    public List<string> AlsoKnownAs { get; set; } = [];

    [JsonPropertyName("biography")]
    public string Biography { get; set; }

    [JsonPropertyName("birthday")]
    [JsonConverter(typeof(StringToDateOnlyConverter))]
    public DateOnly? Birthday { get; set; }

    [JsonPropertyName("gender")]
    public int Gender { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("imdb_id")]
    public string ImdbId { get; set; }

    [JsonPropertyName("known_for_department")]
    public string KnownForDepartment { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("place_of_birth")]
    public string PlaceOfBirth { get; set; }

    [JsonPropertyName("popularity")]
    public float Popularity { get; set; }

    [JsonPropertyName("profile_path")]
    public string ProfilePath { get; set; }

    [JsonPropertyName("changes")]
    public ChangeList Changes { get; set; }

    [JsonPropertyName("combined_credits")]
    public CombinedCredits CombinedCredits { get; set; }

    [JsonPropertyName("external_ids")]
    public CommonExternalIds ExternalIds { get; set; }

    [JsonPropertyName("images")]
    public Images Images { get; set; }

    [JsonPropertyName("movie_credits")]
    public MovieCredits MovieCredits { get; set; }

    [JsonPropertyName("translations")]
    public CommonTranslationList<CommonTranslationData> Translations { get; set; }

    [JsonPropertyName("tv_credits")]
    public TvSeriesCredits TvCredits { get; set; }
}
