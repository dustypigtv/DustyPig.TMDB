using DustyPig.TMDB.JsonHelpers;
using DustyPig.TMDB.Models.Common;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.TvSeries;

public class Details : CommonMedia
{
    public Details()
    {
        MediaType = CommonMediaTypes.TvSeries;
    }

    [JsonPropertyName("created_by")]
    public List<CreatedBy> CreatedBy { get; set; } = [];

    [JsonPropertyName("episode_run_time")]
    public List<int> EpisodeRunTime { get; set; } = [];

    [JsonPropertyName("genres")]
    public List<CommonName> Genres { get; set; } = [];

    [JsonPropertyName("homepage")]
    public string Homepage { get; set; }

    [JsonPropertyName("in_production")]
    public bool InProduction { get; set; }

    [JsonPropertyName("languages")]
    public List<string> Languages { get; set; } = [];

    [JsonPropertyName("last_air_date")]
    [JsonConverter(typeof(StringToDateOnlyConverter))]
    public DateOnly? LastAirDate { get; set; }

    [JsonPropertyName("last_episode_to_air")]
    public LastEpisodeToAir LastEpisodeToAir { get; set; }

    [JsonPropertyName("networks")]
    public List<CommonCompany> Networks { get; set; } = [];

    [JsonPropertyName("number_of_episodes")]
    public int NumberOfEpisodes { get; set; }

    [JsonPropertyName("number_of_seasons")]
    public int NumberOfSeasons { get; set; }

    [JsonPropertyName("production_companies")]
    public List<CommonCompany> ProductionCompanies { get; set; } = [];

    [JsonPropertyName("production_countries")]
    public List<CommonCountry2> ProductionCountries { get; set; } = [];

    [JsonPropertyName("seasons")]
    public List<CommonSeason> Seasons { get; set; } = [];

    [JsonPropertyName("spoken_languages")]
    public List<CommonLanguage> SpokenLanguages { get; set; } = [];

    [JsonPropertyName("status")]
    public string Status { get; set; }

    [JsonPropertyName("tagline")]
    public string Tagline { get; set; }

    [JsonPropertyName("type")]
    [JsonConverter(typeof(TvSeriesTypeConverter))]
    public CommonTvSeriesTypes? Type { get; set; }

    [JsonPropertyName("account_states")]
    public CommonAccountState AccountStates { get; set; }

    [JsonPropertyName("aggregate_credits")]
    public CommonAggregateCredits AggregateCredits { get; set; }

    [JsonPropertyName("alternative_titles")]
    public ListResultWithId<CommonTitle> AlternativeTitles { get; set; }

    [JsonPropertyName("changes")]
    public CommonChanges Changes { get; set; }

    [JsonPropertyName("content_ratings")]
    public ListResultWithId<ContentRating> ContentRatings { get; set; }

    [JsonPropertyName("credits")]
    public CommonTvCredits Credits { get; set; }

    [JsonPropertyName("episode_groups")]
    public ListResultWithId<EpisodeGroup> EpisodeGroups { get; set; }

    [JsonPropertyName("external_ids")]
    public CommonExternalIds ExternalIds { get; set; }

    [JsonPropertyName("images")]
    public CommonImages Images { get; set; }

    [JsonPropertyName("keywords")]
    public ListResultWithId<CommonName> Keywords { get; set; }

    [JsonPropertyName("lists")]
    public PagedResultWithId<Lists> Lists { get; set; }

    [JsonPropertyName("recommendations")]
    public PagedResult<CommonMedia> Recommendations { get; set; }

    [JsonPropertyName("reviews")]
    public PagedResultWithId<CommonReview> Reviews { get; set; }

    [JsonPropertyName("screened_theatrically")]
    public ListResultWithId<ScreenedTheatrically> ScreenedTheatrically { get; set; }

    [JsonPropertyName("similar")]
    public PagedResult<CommonMedia> Similar { get; set; }

    [JsonPropertyName("translations")]
    public CommonTranslationList<CommonTranslation<Translation>> Translations { get; set; }

    [JsonPropertyName("videos")]
    public ListResultWithId<CommonVideo> Videos { get; set; }

    /// <summary>
    /// TO DO:
    /// </summary>
    [JsonPropertyName("next_episode_to_air")]
    public JsonElement NextEpisodeToAir { get; set; }
}