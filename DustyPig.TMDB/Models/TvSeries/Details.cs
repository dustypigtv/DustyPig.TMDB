using DustyPig.TMDB.JsonHelpers;
using DustyPig.TMDB.Models.Common;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.TvSeries;

public class Details : Common.TvSeries
{
    [JsonPropertyName("created_by")]
    public List<CreatedBy> CreatedBy { get; set; } = [];

    [JsonPropertyName("episode_run_time")]
    public List<int> EpisodeRunTime { get; set; } = [];

    [JsonPropertyName("genres")]
    public List<NameObject> Genres { get; set; } = [];

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
    public List<Company> Networks { get; set; } = [];

    [JsonPropertyName("number_of_episodes")]
    public int NumberOfEpisodes { get; set; }

    [JsonPropertyName("number_of_seasons")]
    public int NumberOfSeasons { get; set; }

    [JsonPropertyName("production_companies")]
    public List<Company> ProductionCompanies { get; set; } = [];

    [JsonPropertyName("production_countries")]
    public List<Country2> ProductionCountries { get; set; } = [];

    [JsonPropertyName("seasons")]
    public List<TvSeason> Seasons { get; set; } = [];

    [JsonPropertyName("spoken_languages")]
    public List<Language> SpokenLanguages { get; set; } = [];

    [JsonPropertyName("status")]
    public string Status { get; set; }

    [JsonPropertyName("tagline")]
    public string Tagline { get; set; }

    [JsonPropertyName("type")]
    [JsonConverter(typeof(TvSeriesTypeConverter))]
    public TvSeriesTypes? Type { get; set; }

    [JsonPropertyName("account_states")]
    public AccountState AccountStates { get; set; }

    [JsonPropertyName("aggregate_credits")]
    public AggregateCredits AggregateCredits { get; set; }

    [JsonPropertyName("alternative_titles")]
    public ListResultWithId<TitleObject> AlternativeTitles { get; set; }

    [JsonPropertyName("changes")]
    public ChangesList Changes { get; set; }

    [JsonPropertyName("content_ratings")]
    public ListResultWithId<ContentRating> ContentRatings { get; set; }

    [JsonPropertyName("credits")]
    public TvCredits Credits { get; set; }

    [JsonPropertyName("episode_groups")]
    public ListResultWithId<EpisodeGroup> EpisodeGroups { get; set; }

    [JsonPropertyName("external_ids")]
    public ExternalIds ExternalIds { get; set; }

    [JsonPropertyName("images")]
    public Images Images { get; set; }

    [JsonPropertyName("keywords")]
    public ListResultWithId<NameObject> Keywords { get; set; }

    [JsonPropertyName("lists")]
    public PagedResultWithId<Lists> Lists { get; set; }

    [JsonPropertyName("recommendations")]
    public PagedResult<Common.TvSeries> Recommendations { get; set; }

    [JsonPropertyName("reviews")]
    public PagedResultWithId<Review> Reviews { get; set; }

    [JsonPropertyName("screened_theatrically")]
    public ListResultWithId<ScreenedTheatrically> ScreenedTheatrically { get; set; }

    [JsonPropertyName("similar")]
    public PagedResult<Common.TvSeries> Similar { get; set; }

    [JsonPropertyName("translations")]
    public TranslationList<TranslationData> Translations { get; set; }

    [JsonPropertyName("videos")]
    public ListResultWithId<Video> Videos { get; set; }

    /// <summary>
    /// TO DO:
    /// </summary>
    [JsonPropertyName("next_episode_to_air")]
    public JsonElement NextEpisodeToAir { get; set; }
}