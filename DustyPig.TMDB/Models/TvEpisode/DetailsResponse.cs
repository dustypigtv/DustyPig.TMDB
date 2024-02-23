using DustyPig.TMDB.JsonHelpers;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.TvEpisode;

public class DetailsResponse
{
    [JsonPropertyName("air_date")]
    [JsonConverter(typeof(StringToDateOnlyConverter))]
    public DateOnly? AirDate { get; set; }

    [JsonPropertyName("crew")]
    public List<CrewObject2> Crew { get; set; } = [];

    [JsonPropertyName("episode_number")]
    public int EpisodeNumber { get; set; }

    [JsonPropertyName("guest_stars")]
    public List<GuestStarsObject2> GuestStars { get; set; } = [];

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("overview")]
    public string Overview { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("production_code")]
    public string ProductionCode { get; set; }

    [JsonPropertyName("runtime")]
    public int Runtime { get; set; }

    [JsonPropertyName("season_number")]
    public int SeasonNumber { get; set; }

    [JsonPropertyName("still_path")]
    public string StillPath { get; set; }

    [JsonPropertyName("vote_average")]
    public float VoteAverage { get; set; }

    [JsonPropertyName("vote_count")]
    public int VoteCount { get; set; }

    [JsonPropertyName("account_states")]
    public AccountStatesResponse AccountStates { get; set; }

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
