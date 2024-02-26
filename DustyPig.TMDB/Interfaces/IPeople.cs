using DustyPig.TMDB.Models.Common;
using DustyPig.TMDB.Models.People;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Interfaces;

public interface IPeople
{
    /// <summary>
    /// Get the recent changes for a person.
    /// </summary>
    public Task<Response<ChangeList>> GetChangesAsync(int personId, int page = 1, DateOnly? endDate = null, DateOnly? startDate = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the combined movie and TV credits that belong to a person.
    /// </summary>
    public Task<Response<CombinedCredits>> GetCombinedCreditsAsync(int personId, string language = "en-US", CancellationToken cancellationToken = default);

    /// <summary>
    /// Query the top level details of a person.
    /// </summary>
    /// <param name="appendToResponse">Info from endpoints in this namespace to add to the response. 20 values max.</param>
    public Task<Response<Details>> GetDetailsAsync(int personId, AppendToResponse? appendToResponse = null, string language = "en-US", CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the external ID&#39;s that belong to a person.
    /// </summary>
    public Task<Response<CommonExternalIds>> GetExternalIdsAsync(int personId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the profile images that belong to a person.
    /// </summary>
    public Task<Response<Images>> GetImagesAsync(int personId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the newest created person. This is a live response and will continuously change.
    /// </summary>
    public Task<Response<Latest>> GetLatestAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the movie credits for a person.
    /// </summary>
    public Task<Response<MovieCredits>> GetMovieCreditsAsync(int personId, string language = "en-US", CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the translations that belong to a person.
    /// </summary>
    public Task<Response<CommonTranslationList<CommonTranslationData>>> GetTranslationsAsync(int personId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the TV credits that belong to a person.
    /// </summary>
    public Task<Response<TvSeriesCredits>> GetTvSeriesCreditsAsync(int personId, string language = "en-US", CancellationToken cancellationToken = default);
}
