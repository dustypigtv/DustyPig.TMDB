using DustyPig.REST;
using DustyPig.TMDB.Models.Common;
using DustyPig.TMDB.Models.TvSeason;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Interfaces;

public interface ITvSeason
{
    /// <summary>
    /// Get the rating, watchlist and favourite status.
    /// </summary>
    public Task<Response<ListResultWithId<AccountStatesResponse>>> GetAccountStatesAsync(int seasonNumber, int seriesId, string guestSessionId = null, string sessionId = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the aggregate credits (cast and crew) that have been added to a TV season.
    /// </summary>
    public Task<Response<AggregateCreditsResponse>> GetAggregateCreditsAsync(int seasonNumber, int seriesId, string language = "en-US", CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the recent changes for a TV season.
    /// </summary>
    public Task<Response<ChangesResponse>> GetChangesAsync(int seasonId, int page = 1, DateOnly? endDate = null, DateOnly? startDate = null, CancellationToken cancellationToken = default);

    public Task<Response<CreditsResponse>> GetCreditsAsync(int seasonNumber, int seriesId, string language = "en-US", CancellationToken cancellationToken = default);

    /// <summary>
    /// Query the details of a TV season.
    /// </summary>
    /// <param name="appendToResponse">Info from endpoints in this namespace to add to the response. 20 values max.</param>
    public Task<Response<DetailsResponse>> GetDetailsAsync(int seasonNumber, int seriesId, AppendToResponse? appendToResponse = null, string language = "en-US", CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a list of external IDs that have been added to a TV season.
    /// </summary>
    public Task<Response<ExternalIdsResponse>> GetExternalIdsAsync(int seasonNumber, int seriesId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the images that belong to a TV season.
    /// </summary>
    /// <param name="includeImageLanguage">specify a comma separated list of ISO-639-1 values to query, for example: `en,null`</param>
    public Task<Response<ImagesResponse>> GetImagesAsync(int seasonNumber, int seriesId, string includeImageLanguage = null, string language = "en-US", CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the translations for a TV season.
    /// </summary>
    public Task<Response<TranslationsResponse>> GetTranslationsAsync(int seasonNumber, int seriesId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the videos that belong to a TV season.
    /// </summary>
    /// <param name="includeVideoLanguage">filter the list results by language, supports more than one value by using a comma</param>
    public Task<Response<ListResultWithId<VideosResponse>>> GetVideosAsync(int seasonNumber, int seriesId, string includeVideoLanguage = null, string language = "en-US", CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the list of streaming providers we have for a TV season.
    /// </summary>
    public Task<Response<ListResultWithId<WatchProvidersResponse>>> GetWatchProvidersAsync(int seasonNumber, int seriesId, string language = "en-US", CancellationToken cancellationToken = default);
}
