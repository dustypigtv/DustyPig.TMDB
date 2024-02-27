using DustyPig.REST;
using DustyPig.TMDB.Models.Common;
using DustyPig.TMDB.Models.Configuration;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Interfaces;

public interface IConfiguration
{
    /// <summary>
    /// Get the list of countries (ISO 3166-1 tags) used throughout TMDB.
    /// </summary>
    public Task<Response<List<CommonCountry1>>> GetCountriesAsync(string language = "en-US", CancellationToken cancellationToken = default);

    /// <summary>
    /// Query the API configuration details.
    /// </summary>
    public Task<Response<Details>> GetDetailsAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the list of the jobs and departments we use on TMDB.
    /// </summary>
    public Task<Response<List<JobsResponse>>> GetJobsAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the list of languages (ISO 639-1 tags) used throughout TMDB.
    /// </summary>
    public Task<Response<List<CommonLanguage>>> GetLanguagesAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a list of the officially supported translations on TMDB.
    /// </summary>
    public Task<Response<List<string>>> GetPrimaryTranslationsAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the list of timezones used throughout TMDB.
    /// </summary>
    public Task<Response<List<TimeZones>>> GetTimezonesAsync(CancellationToken cancellationToken = default);
}
