using DustyPig.REST;
using DustyPig.TMDB.Models.Common;
using DustyPig.TMDB.Models.TvSeries;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Interfaces;

public interface ITvSeries
{
    /// <summary>
    /// Get the rating, watchlist and favourite status.
    /// </summary>
    public Task<Response<CommonAccountState>> GetAccountStatesAsync(int seriesId, string guestSessionId = null, string sessionId = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Rate a TV show and save it to your rated list.
    /// </summary>
    public Task<Response<CommonStatus>> AddRatingAsync(CommonValue1 postData, int seriesId, string guestSessionId = null, string sessionId = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the aggregate credits (cast and crew) that have been added to a TV show.
    /// </summary>
    public Task<Response<AggregateCreditsResponse>> GetAggregateCreditsAsync(int seriesId, string language = "en-US", CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a list of TV shows airing today.
    /// </summary>
    public Task<Response<PagedResult<CommonTvSeries2>>> GetAiringTodayAsync(int page = 1, string language = "en-US", string timezone = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the alternative titles that have been added to a TV show.
    /// </summary>
    public Task<Response<ListResultWithId<CommonTitle>>> GetAlternativeTitlesAsync(int seriesId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the recent changes for a TV show.
    /// </summary>
    public Task<Response<CommonChanges>> GetChangesAsync(int seriesId, int page = 1, DateOnly? endDate = null, DateOnly? startDate = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the content ratings that have been added to a TV show.
    /// </summary>
    public Task<Response<ListResultWithId<ContentRatingsResponse>>> GetContentRatingsAsync(int seriesId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the latest season credits of a TV show.
    /// </summary>
    public Task<Response<CreditsResponse>> GetCreditsAsync(int seriesId, string language = "en-US", CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the details of a TV show.
    /// </summary>
    /// <param name="appendToResponse">Info from endpoints in this namespace to add to the response. 20 values max.</param>
    public Task<Response<DetailsResponse>> GetDetailsAsync(int seriesId, AppendToResponse? appendToResponse = null, string language = "en-US", CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the episode groups that have been added to a TV show.
    /// </summary>
    public Task<Response<ListResultWithId<EpisodeGroupsResponse>>> GetEpisodeGroupsAsync(int seriesId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a list of external IDs that have been added to a TV show.
    /// </summary>
    public Task<Response<ExternalIdsResponse>> GetExternalIdsAsync(int seriesId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the images that belong to a TV series.
    /// </summary>
    /// <param name="includeImageLanguage">specify a comma separated list of ISO-639-1 values to query, for example: `en,null`</param>
    public Task<Response<CommonImages2>> GetImagesAsync(int seriesId, string includeImageLanguage = null, string language = "en-US", CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a list of keywords that have been added to a TV show.
    /// </summary>
    public Task<Response<ListResultWithId<CommonName>>> GetKeywordsAsync(int seriesId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the newest TV show ID.
    /// </summary>
    public Task<Response<LatestResponse>> GetLatestAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the lists that a TV series has been added to.
    /// </summary>
    public Task<Response<PagedResultWithId<ListsResponse>>> GetListsAsync(int seriesId, int page = 1, string language = "en-US", CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a list of TV shows that air in the next 7 days.
    /// </summary>
    public Task<Response<PagedResult<CommonTvSeries2>>> GetOnTheAirAsync(int page = 1, string language = "en-US", string timezone = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a list of TV shows ordered by popularity.
    /// </summary>
    public Task<Response<PagedResult<CommonTvSeries2>>> GetPopularAsync(int page = 1, string language = "en-US", CancellationToken cancellationToken = default);

    public Task<Response<PagedResult<CommonTvSeries3>>> GetRecommendationsAsync(int seriesId, int page = 1, string language = "en-US", CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the reviews that have been added to a TV show.
    /// </summary>
    public Task<Response<PagedResultWithId<ReviewsResponse>>> GetReviewsAsync(int seriesId, int page = 1, string language = "en-US", CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the seasons and episodes that have screened theatrically.
    /// </summary>
    public Task<Response<ListResultWithId<ScreenedTheatricallyResponse>>> GetScreenedTheatricallyAsync(int seriesId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the similar TV shows.
    /// </summary>
    public Task<Response<PagedResult<CommonTvSeries1>>> GetSimilarAsync(string seriesId, int page = 1, string language = "en-US", CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a list of TV shows ordered by rating.
    /// </summary>
    public Task<Response<PagedResult<CommonTvSeries2>>> GetTopRatedAsync(int page = 1, string language = "en-US", CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the translations that have been added to a TV show.
    /// </summary>
    public Task<Response<TranslationsResponse>> GetTranslationsAsync(int seriesId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the videos that belong to a TV show.
    /// </summary>
    /// <param name="includeVideoLanguage">filter the list results by language, supports more than one value by using a comma</param>
    public Task<Response<ListResultWithId<CommonVideo>>> GetVideosAsync(int seriesId, string includeVideoLanguage = null, string language = "en-US", CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the list of streaming providers we have for a TV show.
    /// </summary>
    public Task<Response<ListResultWithId<CommonProvider>>> GetWatchProvidersAsync(int seriesId, CancellationToken cancellationToken = default);
}
