using DustyPig.TMDB.Models.Common;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Movies;

public class Details : CommonMedia
{
    public Details()
    {
        MediaType = CommonMediaTypes.Movie;
    }

    [JsonPropertyName("budget")]
    public int Budget { get; set; }

    [JsonPropertyName("genres")]
    public List<CommonName> Genres { get; set; } = [];

    [JsonPropertyName("homepage")]
    public string Homepage { get; set; }

    [JsonPropertyName("imdb_id")]
    public string ImdbId { get; set; }

    [JsonPropertyName("production_companies")]
    public List<CommonCompany> ProductionCompanies { get; set; } = [];

    [JsonPropertyName("production_countries")]
    public List<CommonCountry2> ProductionCountries { get; set; } = [];

    [JsonPropertyName("revenue")]
    public long Revenue { get; set; }

    [JsonPropertyName("runtime")]
    public int? Runtime { get; set; }

    [JsonPropertyName("spoken_languages")]
    public List<CommonLanguage> SpokenLanguages { get; set; } = [];

    [JsonPropertyName("status")]
    public string Status { get; set; }

    [JsonPropertyName("tagline")]
    public string Tagline { get; set; }

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
    public CommonImages Images { get; set; }

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
    public PagedResult<CommonMedia> Similar { get; set; }

    [JsonPropertyName("translations")]
    public CommonTranslationList<CommonTranslation<Translation>> Translations { get; set; }


    [JsonPropertyName("videos")]
    public ListResultWithId<CommonVideo> Videos { get; set; }
}
