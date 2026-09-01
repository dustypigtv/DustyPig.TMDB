using DustyPig.TMDB.Models.Common;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Movies;

public class Details : Movie
{
    [JsonPropertyName("belongs_to_collection")]
    public Collections.Basic BelongsToCollection { get; set; }

    [JsonPropertyName("budget")]
    public int Budget { get; set; }

    [JsonPropertyName("genres")]
    public List<NameObject> Genres { get; set; } = [];

    [JsonPropertyName("homepage")]
    public string Homepage { get; set; }

    [JsonPropertyName("imdb_id")]
    public string ImdbId { get; set; }

    [JsonPropertyName("production_companies")]
    public List<Company> ProductionCompanies { get; set; } = [];

    [JsonPropertyName("production_countries")]
    public List<Country2> ProductionCountries { get; set; } = [];

    [JsonPropertyName("revenue")]
    public long Revenue { get; set; }

    [JsonPropertyName("runtime")]
    public int? Runtime { get; set; }

    [JsonPropertyName("spoken_languages")]
    public List<Language> SpokenLanguages { get; set; } = [];

    [JsonPropertyName("status")]
    public string Status { get; set; }

    [JsonPropertyName("tagline")]
    public string Tagline { get; set; }

    [JsonPropertyName("account_states")]
    public AccountState AccountStates { get; set; }

    [JsonPropertyName("alternative_titles")]
    public AlternativeTitle AlternativeTitles { get; set; }

    [JsonPropertyName("changes")]
    public ChangesList Changes { get; set; }

    [JsonPropertyName("credits")]
    public Credits Credits { get; set; }

    [JsonPropertyName("external_ids")]
    public ExternalIds ExternalIds { get; set; }

    [JsonPropertyName("images")]
    public Images Images { get; set; }

    [JsonPropertyName("keywords")]
    public KeywordsList Keywords { get; set; }

    [JsonPropertyName("lists")]
    public PagedResultWithId<MediaList> Lists { get; set; }

    [JsonPropertyName("recommendations")]
    public PagedResult<Movie> Recommendations { get; set; }

    [JsonPropertyName("release_dates")]
    public ListResultWithId<Releases> ReleaseDates { get; set; }

    [JsonPropertyName("reviews")]
    public PagedResultWithId<Review> Reviews { get; set; }

    [JsonPropertyName("similar")]
    public PagedResult<Movie> Similar { get; set; }

    [JsonPropertyName("translations")]
    public TranslationList<TranslationData> Translations { get; set; }


    [JsonPropertyName("videos")]
    public ListResultWithId<Video> Videos { get; set; }
}
