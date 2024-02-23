using DustyPig.TMDB.JsonHelpers;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Movie;

public class DetailsResponse
{
    [JsonPropertyName("adult")]
    public bool Adult { get; set; }

    [JsonPropertyName("backdrop_path")]
    public string BackdropPath { get; set; }

    [JsonPropertyName("budget")]
    public int Budget { get; set; }

    [JsonPropertyName("genres")]
    public List<GenresObject> Genres { get; set; } = [];

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
    public List<ProductionCompaniesObject> ProductionCompanies { get; set; } = [];

    [JsonPropertyName("production_countries")]
    public List<ProductionCountriesObject> ProductionCountries { get; set; } = [];

    [JsonPropertyName("release_date")]
    [JsonConverter(typeof(StringToDateOnlyConverter))]
    public DateOnly? ReleaseDate { get; set; }

    [JsonPropertyName("revenue")]
    public int Revenue { get; set; }

    [JsonPropertyName("runtime")]
    public int Runtime { get; set; }

    [JsonPropertyName("spoken_languages")]
    public List<SpokenLanguagesObject> SpokenLanguages { get; set; } = [];

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
    public AccountStatesResponse AccountStates { get; set; }

    [JsonPropertyName("alternative_titles")]
    public AlternativeTitlesResponse AlternativeTitles { get; set; }

    [JsonPropertyName("changes")]
    public ChangesResponse Changes { get; set; }

    [JsonPropertyName("credits")]
    public CreditsResponse Credits { get; set; }

    [JsonPropertyName("external_ids")]
    public ExternalIdsResponse ExternalIds { get; set; }

    [JsonPropertyName("images")]
    public ImagesResponse Images { get; set; }

    [JsonPropertyName("keywords")]
    public KeywordsResponse Keywords { get; set; }

    [JsonPropertyName("lists")]
    public PagedResultWithId<ListsResponse> Lists { get; set; }

    [JsonPropertyName("recommendations")]
    public PagedResult<RecommendationsResponse> Recommendations { get; set; }

    [JsonPropertyName("release_dates")]
    public ListResultWithId<ReleaseDatesResponse> ReleaseDates { get; set; }

    [JsonPropertyName("reviews")]
    public PagedResultWithId<ReviewsResponse> Reviews { get; set; }

    [JsonPropertyName("similar")]
    public PagedResult<SimilarResponse> Similar { get; set; }

    [JsonPropertyName("translations")]
    public TranslationsResponse Translations { get; set; }

    [JsonPropertyName("videos")]
    public ListResultWithId<VideosResponse> Videos { get; set; }
}
