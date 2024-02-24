using DustyPig.REST;
using DustyPig.TMDB.Interfaces;
using DustyPig.TMDB.Models.Common;
using DustyPig.TMDB.Models.Configuration;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Clients;

internal class ConfigurationClient : IConfiguration
{
    private readonly Client _client;

    internal ConfigurationClient(Client client) => _client = client;


    /// <summary>
    /// Get the list of countries (ISO 3166-1 tags) used throughout TMDB.
    /// </summary>
    public Task<Response<List<CommonCountry1>>> GetCountriesAsync(string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "language", language }
        };

        return _client.GetAsync<List<CommonCountry1>>("/3/configuration/countries", queryParams, cancellationToken);
    }

    /// <summary>
    /// Query the API configuration details.
    /// </summary>
    public Task<Response<DetailsResponse>> GetDetailsAsync(CancellationToken cancellationToken = default) =>
        _client.GetAsync<DetailsResponse>("/3/configuration", null, cancellationToken);

    /// <summary>
    /// Get the list of the jobs and departments we use on TMDB.
    /// </summary>
    public Task<Response<List<JobsResponse>>> GetJobsAsync(CancellationToken cancellationToken = default) =>
        _client.GetAsync<List<JobsResponse>>("/3/configuration/jobs", null, cancellationToken);

    /// <summary>
    /// Get the list of languages (ISO 639-1 tags) used throughout TMDB.
    /// </summary>
    public Task<Response<List<CommonLanguage>>> GetLanguagesAsync(CancellationToken cancellationToken = default) =>
        _client.GetAsync<List<CommonLanguage>>("/3/configuration/languages", null, cancellationToken);

    /// <summary>
    /// Get a list of the officially supported translations on TMDB.
    /// </summary>
    public Task<Response<List<string>>> GetPrimaryTranslationsAsync(CancellationToken cancellationToken = default) =>
        _client.GetAsync<List<string>>("/3/configuration/primary_translations", null, cancellationToken);

    /// <summary>
    /// Get the list of timezones used throughout TMDB.
    /// </summary>
    public Task<Response<List<TimezonesResponse>>> GetTimezonesAsync(CancellationToken cancellationToken = default) =>
        _client.GetAsync<List<TimezonesResponse>>("/3/configuration/timezones", null, cancellationToken);
}
