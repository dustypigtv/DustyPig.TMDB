using DustyPig.TMDB.JsonHelpers;
using DustyPig.TMDB.Models.Common;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.TvSeasons;

public class Details : ModelBase
{
    [JsonPropertyName("_id")]
    public string _Id { get; set; }

    [JsonPropertyName("air_date")]
    [JsonConverter(typeof(StringToDateOnlyConverter))]
    public DateOnly? AirDate { get; set; }

    [JsonPropertyName("episodes")]
    public List<Episode> Episodes { get; set; } = [];

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("overview")]
    public string Overview { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("poster_path")]
    public string PosterPath { get; set; }

    [JsonPropertyName("season_number")]
    public int SeasonNumber { get; set; }

    [JsonPropertyName("vote_average")]
    public float VoteAverage { get; set; }

    [JsonPropertyName("account_states")]
    public ListResultWithId<AccountState> AccountStates { get; set; }

    [JsonPropertyName("aggregate_credits")]
    public AggregateCredits AggregateCredits { get; set; }

    [JsonPropertyName("credits")]
    public TvCredits Credits { get; set; }

    [JsonPropertyName("external_ids")]
    public ExternalIds ExternalIds { get; set; }

    [JsonPropertyName("images")]
    public Images Images { get; set; }

    [JsonPropertyName("translations")]
    public TranslationList<TranslationData> Translations { get; set; }

    [JsonPropertyName("videos")]
    public ListResultWithId<Video> Videos { get; set; }

    [JsonPropertyName("networks")]
    public List<Company> Networks { get; set; } = [];
}
