using DustyPig.TMDB.JsonHelpers;
using DustyPig.TMDB.Models.Common;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.TvSeries;

public class DetailsResponse
{
    [JsonPropertyName("adult")]
    public bool Adult { get; set; }

    [JsonPropertyName("backdrop_path")]
    public string BackdropPath { get; set; }

    [JsonPropertyName("created_by")]
    public List<CreatedByObject> CreatedBy { get; set; } = [];

    [JsonPropertyName("episode_run_time")]
    public List<int> EpisodeRunTime { get; set; } = [];

    [JsonPropertyName("first_air_date")]
    [JsonConverter(typeof(StringToDateOnlyConverter))]
    public DateOnly? FirstAirDate { get; set; }

    [JsonPropertyName("genres")]
    public List<CommonName> Genres { get; set; } = [];

    [JsonPropertyName("homepage")]
    public string Homepage { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("in_production")]
    public bool InProduction { get; set; }

    [JsonPropertyName("languages")]
    public List<string> Languages { get; set; } = [];

    [JsonPropertyName("last_air_date")]
    [JsonConverter(typeof(StringToDateOnlyConverter))]
    public DateOnly? LastAirDate { get; set; }

    [JsonPropertyName("last_episode_to_air")]
    public LastEpisodeToAirObject LastEpisodeToAir { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("networks")]
    public List<CommonCompany> Networks { get; set; } = [];

    [JsonPropertyName("number_of_episodes")]
    public int NumberOfEpisodes { get; set; }

    [JsonPropertyName("number_of_seasons")]
    public int NumberOfSeasons { get; set; }

    [JsonPropertyName("origin_country")]
    public List<string> OriginCountry { get; set; } = [];

    [JsonPropertyName("original_language")]
    public string OriginalLanguage { get; set; }

    [JsonPropertyName("original_name")]
    public string OriginalName { get; set; }

    [JsonPropertyName("overview")]
    public string Overview { get; set; }

    [JsonPropertyName("popularity")]
    public float Popularity { get; set; }

    [JsonPropertyName("poster_path")]
    public string PosterPath { get; set; }

    [JsonPropertyName("production_companies")]
    public List<CommonCompany> ProductionCompanies { get; set; } = [];

    [JsonPropertyName("production_countries")]
    public List<ProductionCountriesObject> ProductionCountries { get; set; } = [];

    [JsonPropertyName("seasons")]
    public List<SeasonsObject> Seasons { get; set; } = [];

    [JsonPropertyName("spoken_languages")]
    public List<SpokenLanguagesObject> SpokenLanguages { get; set; } = [];

    [JsonPropertyName("status")]
    public string Status { get; set; }

    [JsonPropertyName("tagline")]
    public string Tagline { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("vote_average")]
    public float VoteAverage { get; set; }

    [JsonPropertyName("vote_count")]
    public int VoteCount { get; set; }

    [JsonPropertyName("account_states")]
    public AccountStatesResponse AccountStates { get; set; }

    [JsonPropertyName("aggregate_credits")]
    public AggregateCreditsResponse AggregateCredits { get; set; }

    [JsonPropertyName("alternative_titles")]
    public ListResultWithId<AlternativeTitlesResponse> AlternativeTitles { get; set; }

    [JsonPropertyName("changes")]
    public ChangesResponse Changes { get; set; }

    [JsonPropertyName("content_ratings")]
    public ListResultWithId<ContentRatingsResponse> ContentRatings { get; set; }

    [JsonPropertyName("credits")]
    public CreditsResponse Credits { get; set; }

    [JsonPropertyName("episode_groups")]
    public ListResultWithId<EpisodeGroupsResponse> EpisodeGroups { get; set; }

    [JsonPropertyName("external_ids")]
    public ExternalIdsResponse ExternalIds { get; set; }

    [JsonPropertyName("images")]
    public ImagesResponse Images { get; set; }

    [JsonPropertyName("keywords")]
    public ListResultWithId<CommonName> Keywords { get; set; }

    [JsonPropertyName("lists")]
    public PagedResultWithId<ListsResponse> Lists { get; set; }

    [JsonPropertyName("recommendations")]
    public PagedResult<RecommendationsResponse> Recommendations { get; set; }

    [JsonPropertyName("reviews")]
    public PagedResultWithId<ReviewsResponse> Reviews { get; set; }

    [JsonPropertyName("screened_theatrically")]
    public ListResultWithId<ScreenedTheatricallyResponse> ScreenedTheatrically { get; set; }

    [JsonPropertyName("similar")]
    public PagedResult<Models.Common.CommonTvSeries> Similar { get; set; }

    [JsonPropertyName("translations")]
    public TranslationsResponse Translations { get; set; }

    [JsonPropertyName("videos")]
    public ListResultWithId<CommonVideo> Videos { get; set; }
}
