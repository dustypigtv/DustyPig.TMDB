using DustyPig.TMDB.JsonHelpers;
using DustyPig.TMDB.Models.Common;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DustyPig.TMDB.Models.TvSeries;

public class Latest : Common.TvSeries
{
    [JsonPropertyName("created_by")]
    public List<CreatedBy> CreatedBy { get; set; } = [];

    [JsonPropertyName("episode_run_time")]
    public List<int> EpisodeRunTime { get; set; } = [];

    [JsonPropertyName("genres")]
    public List<Name_> Genres { get; set; } = [];

    [JsonPropertyName("languages")]
    public List<string> Languages { get; set; } = [];

    [JsonPropertyName("homepage")]
    public string Homepage { get; set; }

    [JsonPropertyName("in_production")]
    public bool InProduction { get; set; }

    [JsonPropertyName("last_air_date")]
    [JsonConverter(typeof(StringToDateOnlyConverter))]
    public DateOnly? LastAirDate { get; set; }

    [JsonPropertyName("last_episode_to_air")]
    public LastEpisodeToAir LastEpisodeToAir { get; set; }

    [JsonPropertyName("number_of_episodes")]
    public int NumberOfEpisodes { get; set; }

    [JsonPropertyName("number_of_seasons")]
    public int NumberOfSeasons { get; set; }

    [JsonPropertyName("seasons")]
    public List<TvSeason> Seasons { get; set; } = [];

    [JsonPropertyName("status")]
    public string Status { get; set; }

    [JsonPropertyName("tagline")]
    public string Tagline { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("networks")]
    public List<Company> Networks { get; set; } = [];

    [JsonPropertyName("production_companies")]
    public List<Company> ProductionCompanies { get; set; } = [];

    [JsonPropertyName("production_countries")]
    public List<Country2> ProductionCountries { get; set; } = [];

    [JsonPropertyName("spoken_languages")]
    public List<Language> SpokenLanguages { get; set; } = [];

    /// <summary>
    /// TO DO:
    /// </summary>
    [JsonPropertyName("next_episode_to_air")]
    public JsonElement NextEpisodeToAir { get; set; }
}
