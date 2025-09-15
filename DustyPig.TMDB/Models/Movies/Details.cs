using DustyPig.TMDB.JsonHelpers;
using DustyPig.TMDB.Models.Common;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Movies;

public class Details
{
    [JsonPropertyName("adult")]
    public bool Adult { get; set; }

    [JsonPropertyName("backdrop_path")]
    public string BackdropPath { get; set; }

    [JsonPropertyName("budget")]
    public int Budget { get; set; }

    [JsonPropertyName("genres")]
    public List<CommonName> Genres { get; set; } = [];

    [JsonPropertyName("homepage")]
    public string Homepage { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("imdb_id")]
    public string ImdbId { get; set; }

    [JsonPropertyName("original_language")]
    public string OriginalLanguage { get; set; }

    [JsonPropertyName("original_title")]
    public string OriginalTitle { get; set; }

    [JsonPropertyName("overview")]
    public string Overview { get; set; }

    [JsonPropertyName("popularity")]
    public float Popularity { get; set; }

    [JsonPropertyName("poster_path")]
    public string PosterPath { get; set; }

    [JsonPropertyName("production_companies")]
    public List<CommonCompany> ProductionCompanies { get; set; } = [];

    [JsonPropertyName("production_countries")]
    public List<CommonCountry2> ProductionCountries { get; set; } = [];

    [JsonPropertyName("release_date")]
    [JsonConverter(typeof(StringToDateOnlyConverter))]
    public DateOnly? ReleaseDate { get; set; }

    [JsonPropertyName("revenue")]
    public long Revenue { get; set; }

    [JsonPropertyName("runtime")]
    public int Runtime { get; set; }

    [JsonPropertyName("spoken_languages")]
    public List<CommonLanguage> SpokenLanguages { get; set; } = [];

    [JsonPropertyName("status")]
    public string Status { get; set; }

    [JsonPropertyName("tagline")]
    public string Tagline { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("video")]
    public bool Video { get; set; }

    [JsonPropertyName("vote_average")]
    public float VoteAverage { get; set; }

    [JsonPropertyName("vote_count")]
    public int VoteCount { get; set; }

    [JsonPropertyName("account_states")]
    public CommonAccountState AccountStates { get; set; }

    [JsonPropertyName("alternative_titles")]
    public AlternativeTitle AlternativeTitles { get; set; }

    [JsonPropertyName("changes")]
    public CommonChanges Changes { get; set; }

    [JsonPropertyName("credits")]
    public Credits Credits { get; set; }

    [JsonPropertyName("external_ids")]
    public CommonExternalIds ExternalIds { get; set; }

    [JsonPropertyName("images")]
    public CommonImages2 Images { get; set; }

    [JsonPropertyName("keywords")]
    public KeywordsList Keywords { get; set; }

    [JsonPropertyName("lists")]
    public PagedResultWithId<CommonList> Lists { get; set; }

    [JsonPropertyName("recommendations")]
    public PagedResult<CommonMedia> Recommendations { get; set; }

    [JsonPropertyName("release_dates")]
    public ListResultWithId<Releases> ReleaseDates { get; set; }

    [JsonPropertyName("reviews")]
    public PagedResultWithId<Reviews> Reviews { get; set; }

    [JsonPropertyName("similar")]
    public PagedResult<CommonMovie> Similar { get; set; }

    [JsonPropertyName("translations")]
    public CommonTranslationList<CommonTranslation<Translation>> Translations { get; set; }


    [JsonPropertyName("videos")]
    public ListResultWithId<CommonVideo> Videos { get; set; }
}
