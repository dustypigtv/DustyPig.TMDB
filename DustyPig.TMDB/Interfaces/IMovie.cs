using DustyPig.REST;
using DustyPig.TMDB.Models;
using DustyPig.TMDB.Models.Movie;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Interfaces;

public interface IMovie
{
    /// <summary>
    /// Get the rating, watchlist and favourite status of an account.
    /// </summary>
    public Task<Response<AccountStatesResponse>> GetAccountStatesAsync(int movieId, string guestSessionId = null, string sessionId = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Rate a movie and save it to your rated list.
    /// </summary>
    public Task<Response<AddRatingResponse>> AddRatingAsync(AddRatingRequest postData, int movieId, string guestSessionId = null, string sessionId = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the alternative titles for a movie.
    /// </summary>
    /// <param name="country">specify a ISO-3166-1 value to filter the results</param>
    public Task<Response<AlternativeTitlesResponse>> GetAlternativeTitlesAsync(int movieId, string country = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the recent changes for a movie.
    /// </summary>
    public Task<Response<ChangesResponse>> GetChangesAsync(int movieId, int page = 1, DateOnly? endDate = null, DateOnly? startDate = null, CancellationToken cancellationToken = default);

    public Task<Response<CreditsResponse>> GetCreditsAsync(int movieId, string language = "en-US", CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the top level details of a movie by ID.
    /// </summary>
    /// <param name="appendToResponse">Info from endpoints in this namespace to add to the response. 20 values max.</param>
    public Task<Response<DetailsResponse>> GetDetailsAsync(int movieId, AppendToResponse? appendToResponse = null, string language = "en-US", CancellationToken cancellationToken = default);

    public Task<Response<ExternalIdsResponse>> GetExternalIdsAsync(int movieId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the images that belong to a movie.
    /// </summary>
    /// <param name="includeImageLanguage">specify a comma separated list of ISO-639-1 values to query, for example: `en,null`</param>
    public Task<Response<ImagesResponse>> GetImagesAsync(int movieId, string includeImageLanguage = null, string language = "en-US", CancellationToken cancellationToken = default);

    public Task<Response<KeywordsResponse>> GetKeywordsAsync(string movieId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the newest movie ID.
    /// </summary>
    public Task<Response<LatestResponse>> GetLatestAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the lists that a movie has been added to.
    /// </summary>
    public Task<Response<PagedResultWithId<ListsResponse>>> GetListsAsync(int movieId, int page = 1, string language = "en-US", CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a list of movies that are currently in theatres.
    /// </summary>
    /// <param name="region">ISO-3166-1 code</param>
    public Task<Response<NowPlayingResponse>> GetNowPlayingAsync(int page = 1, string language = "en-US", string region = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a list of movies ordered by popularity.
    /// </summary>
    /// <param name="region">ISO-3166-1 code</param>
    public Task<Response<PagedResult<PopularResponse>>> GetPopularAsync(int page = 1, string language = "en-US", string region = null, CancellationToken cancellationToken = default);

    public Task<Response<PagedResult<RecommendationsResponse>>> GetRecommendationsAsync(int movieId, int page = 1, string language = "en-US", CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the release dates and certifications for a movie.
    /// </summary>
    public Task<Response<ReleaseDatesResponse>> GetReleaseDatesAsync(int movieId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the user reviews for a movie.
    /// </summary>
    public Task<Response<PagedResultWithId<ReviewsResponse>>> GetReviewsAsync(int movieId, int page = 1, string language = "en-US", CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the similar movies based on genres and keywords.
    /// </summary>
    public Task<Response<PagedResult<SimilarResponse>>> GetSimilarAsync(int movieId, int page = 1, string language = "en-US", CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a list of movies ordered by rating.
    /// </summary>
    /// <param name="region">ISO-3166-1 code</param>
    public Task<Response<PagedResult<TopRatedResponse>>> GetTopRatedAsync(int page = 1, string language = "en-US", string region = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the translations for a movie.
    /// </summary>
    public Task<Response<TranslationsResponse>> GetTranslationsAsync(int movieId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a list of movies that are being released soon.
    /// </summary>
    /// <param name="region">ISO-3166-1 code</param>
    public Task<Response<UpcomingResponse>> GetUpcomingAsync(int page = 1, string language = "en-US", string region = null, CancellationToken cancellationToken = default);

    public Task<Response<VideosResponse>> GetVideosAsync(int movieId, string language = "en-US", CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the list of streaming providers we have for a movie.
    /// </summary>
    public Task<Response<WatchProvidersResponse>> GetWatchProvidersAsync(int movieId, CancellationToken cancellationToken = default);
}
