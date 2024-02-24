using DustyPig.TMDB.JsonHelpers;
using DustyPig.TMDB.Models.Common;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.TvSeason;

public class DetailsResponse
{
    [JsonPropertyName("_id")]
    public string _Id { get; set; }

    [JsonPropertyName("air_date")]
    [JsonConverter(typeof(StringToDateOnlyConverter))]
    public DateOnly? AirDate { get; set; }

    [JsonPropertyName("episodes")]
    public List<EpisodesObject> Episodes { get; set; } = [];

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
    public ListResultWithId<AccountStatesResponse> AccountStates { get; set; }

    [JsonPropertyName("aggregate_credits")]
    public AggregateCreditsResponse AggregateCredits { get; set; }

    [JsonPropertyName("credits")]
    public CreditsResponse Credits { get; set; }

    [JsonPropertyName("external_ids")]
    public ExternalIdsResponse ExternalIds { get; set; }

    [JsonPropertyName("images")]
    public ImagesResponse Images { get; set; }

    [JsonPropertyName("translations")]
    public TranslationsResponse Translations { get; set; }

    [JsonPropertyName("videos")]
    public ListResultWithId<VideosResponse> Videos { get; set; }
}
