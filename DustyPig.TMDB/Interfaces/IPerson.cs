using DustyPig.REST;
using DustyPig.TMDB.Models.Common;
using DustyPig.TMDB.Models.Person;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Interfaces;

public interface IPerson
{
    /// <summary>
    /// Get the recent changes for a person.
    /// </summary>
    public Task<Response<ChangesResponse>> GetChangesAsync(int personId, int page = 1, DateOnly? endDate = null, DateOnly? startDate = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the combined movie and TV credits that belong to a person.
    /// </summary>
    public Task<Response<CombinedCreditsResponse>> GetCombinedCreditsAsync(string personId, string language = "en-US", CancellationToken cancellationToken = default);

    /// <summary>
    /// Query the top level details of a person.
    /// </summary>
    /// <param name="appendToResponse">Info from endpoints in this namespace to add to the response. 20 values max.</param>
    public Task<Response<DetailsResponse>> GetDetailsAsync(int personId, AppendToResponse? appendToResponse = null, string language = "en-US", CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the external ID&#39;s that belong to a person.
    /// </summary>
    public Task<Response<ExternalIdsResponse>> GetExternalIdsAsync(int personId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the profile images that belong to a person.
    /// </summary>
    public Task<Response<ImagesResponse>> GetImagesAsync(int personId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the newest created person. This is a live response and will continuously change.
    /// </summary>
    public Task<Response<LatestResponse>> GetLatestAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the movie credits for a person.
    /// </summary>
    public Task<Response<MovieCreditsResponse>> GetMovieCreditsAsync(int personId, string language = "en-US", CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a list of people ordered by popularity.
    /// </summary>
    public Task<Response<PagedResult<PopularResponse>>> GetPopularAsync(int page = 1, string language = "en-US", CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the translations that belong to a person.
    /// </summary>
    public Task<Response<CommonTranslationList<CommonTranslationData>>> GetTranslationsAsync(int personId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the TV credits that belong to a person.
    /// </summary>
    public Task<Response<TvCreditsResponse>> GetTvCreditsAsync(int personId, string language = "en-US", CancellationToken cancellationToken = default);
}
