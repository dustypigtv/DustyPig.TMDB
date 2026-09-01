using DustyPig.TMDB.Models.Common;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.Movies;

public class Latest : CommonMedia
{
    [JsonPropertyName("belongs_to_collection")]
    public Collections.Basic BelongsToCollection { get; set; }

    [JsonPropertyName("genres")]
    public List<CommonName> Genres { get; set; } = [];

    [JsonPropertyName("imdb_id")]
    public string ImdbId { get; set; }

    [JsonPropertyName("production_companies")]
    public List<CommonCompany> ProductionCompanies { get; set; } = [];

    [JsonPropertyName("production_countries")]
    public List<CommonCountry2> ProductionCountries { get; set; } = [];

    [JsonPropertyName("spoken_languages")]
    public List<CommonLanguage> SpokenLanguages { get; set; } = [];

    [JsonPropertyName("budget")]
    public int Budget { get; set; }

    [JsonPropertyName("homepage")]
    public string Homepage { get; set; }

    [JsonPropertyName("revenue")]
    public long Revenue { get; set; }

    [JsonPropertyName("runtime")]
    public int? Runtime { get; set; }

    [JsonPropertyName("status")]
    public string Status { get; set; }

    [JsonPropertyName("tagline")]
    public string Tagline { get; set; }
}