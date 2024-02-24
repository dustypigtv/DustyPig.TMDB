using DustyPig.REST;
using DustyPig.TMDB.Interfaces;
using DustyPig.TMDB.Models.Common;
using DustyPig.TMDB.Models.Movie;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Clients;

internal class MovieClient : IMovie
{
    private readonly Client _client;

    internal MovieClient(Client client) => _client = client;


    /// <summary>
    /// Get the rating, watchlist and favourite status of an account.
    /// </summary>
    public Task<Response<AccountStatesResponse>> GetAccountStatesAsync(int movieId, string guestSessionId = null, string sessionId = null, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "guest_session_id", guestSessionId },
            { "session_id", sessionId }
        };

        return _client.GetAsync<AccountStatesResponse>($"/3/movie/{movieId}/account_states", queryParams, cancellationToken);
    }

    /// <summary>
    /// Rate a movie and save it to your rated list.
    /// </summary>
    public Task<Response<StatusResponse>> AddRatingAsync(AddRatingRequest postData, int movieId, string guestSessionId = null, string sessionId = null, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "guest_session_id", guestSessionId },
            { "session_id", sessionId }
        };

        return _client.PostAsync<StatusResponse>($"/3/movie/{movieId}/rating", queryParams, postData, cancellationToken);
    }

    /// <summary>
    /// Get the alternative titles for a movie.
    /// </summary>
    /// <param name="country">specify a ISO-3166-1 value to filter the results</param>
    public Task<Response<AlternativeTitlesResponse>> GetAlternativeTitlesAsync(int movieId, string country = null, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "country", country }
        };

        return _client.GetAsync<AlternativeTitlesResponse>($"/3/movie/{movieId}/alternative_titles", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get the recent changes for a movie.
    /// </summary>
    public Task<Response<ChangesResponse>> GetChangesAsync(int movieId, int page = 1, DateOnly? endDate = null, DateOnly? startDate = null, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "end_date", endDate.DateOnlyToTmdb() },
            { "start_date", startDate.DateOnlyToTmdb() }
        };

        return _client.GetAsync<ChangesResponse>($"/3/movie/{movieId}/changes", queryParams, cancellationToken);
    }

    public Task<Response<CreditsResponse>> GetCreditsAsync(int movieId, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "language", language }
        };

        return _client.GetAsync<CreditsResponse>($"/3/movie/{movieId}/credits", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get the top level details of a movie by ID.
    /// </summary>
    /// <param name="appendToResponse">Info from endpoints in this namespace to add to the response. 20 values max.</param>
    public Task<Response<DetailsResponse>> GetDetailsAsync(int movieId, AppendToResponse? appendToResponse = null, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "append_to_response", appendToResponse?.GetEnumDescription() },
            { "language", language }
        };

        return _client.GetAsync<DetailsResponse>($"/3/movie/{movieId}", queryParams, cancellationToken);
    }

    public Task<Response<ExternalIdsResponse>> GetExternalIdsAsync(int movieId, CancellationToken cancellationToken = default) =>
        _client.GetAsync<ExternalIdsResponse>($"/3/movie/{movieId}/external_ids", null, cancellationToken);

    /// <summary>
    /// Get the images that belong to a movie.
    /// </summary>
    /// <param name="includeImageLanguage">specify a comma separated list of ISO-639-1 values to query, for example: `en,null`</param>
    public Task<Response<ImagesResponse>> GetImagesAsync(int movieId, string includeImageLanguage = null, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "include_image_language", includeImageLanguage },
            { "language", language }
        };

        return _client.GetAsync<ImagesResponse>($"/3/movie/{movieId}/images", queryParams, cancellationToken);
    }

    public Task<Response<KeywordsResponse>> GetKeywordsAsync(string movieId, CancellationToken cancellationToken = default) =>
        _client.GetAsync<KeywordsResponse>($"/3/movie/{movieId}/keywords", null, cancellationToken);

    /// <summary>
    /// Get the newest movie ID.
    /// </summary>
    public Task<Response<LatestResponse>> GetLatestAsync(CancellationToken cancellationToken = default) =>
        _client.GetAsync<LatestResponse>("/3/movie/latest", null, cancellationToken);

    /// <summary>
    /// Get the lists that a movie has been added to.
    /// </summary>
    public Task<Response<PagedResultWithId<ListsResponse>>> GetListsAsync(int movieId, int page = 1, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "language", language }
        };

        return _client.GetAsync<PagedResultWithId<ListsResponse>>($"/3/movie/{movieId}/lists", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get a list of movies that are currently in theatres.
    /// </summary>
    /// <param name="region">ISO-3166-1 code</param>
    public Task<Response<PagedResultWithDateRange<MovieObject>>> GetNowPlayingAsync(int page = 1, string language = "en-US", string region = null, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "language", language },
            { "region", region }
        };

        return _client.GetAsync<PagedResultWithDateRange<MovieObject>>("/3/movie/now_playing", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get a list of movies ordered by popularity.
    /// </summary>
    /// <param name="region">ISO-3166-1 code</param>
    public Task<Response<PagedResult<MovieObject>>> GetPopularAsync(int page = 1, string language = "en-US", string region = null, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "language", language },
            { "region", region }
        };

        return _client.GetAsync<PagedResult<MovieObject>>("/3/movie/popular", queryParams, cancellationToken);
    }

    public Task<Response<PagedResult<MediaObject>>> GetRecommendationsAsync(int movieId, int page = 1, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "language", language }
        };

        return _client.GetAsync<PagedResult<MediaObject>>($"/3/movie/{movieId}/recommendations", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get the release dates and certifications for a movie.
    /// </summary>
    public Task<Response<ListResultWithId<ReleaseDatesResponse>>> GetReleaseDatesAsync(int movieId, CancellationToken cancellationToken = default) =>
        _client.GetAsync<ListResultWithId<ReleaseDatesResponse>>($"/3/movie/{movieId}/release_dates", null, cancellationToken);

    /// <summary>
    /// Get the user reviews for a movie.
    /// </summary>
    public Task<Response<PagedResultWithId<ReviewsResponse>>> GetReviewsAsync(int movieId, int page = 1, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "language", language }
        };

        return _client.GetAsync<PagedResultWithId<ReviewsResponse>>($"/3/movie/{movieId}/reviews", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get the similar movies based on genres and keywords.
    /// </summary>
    public Task<Response<PagedResult<MovieObject>>> GetSimilarAsync(int movieId, int page = 1, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "language", language }
        };

        return _client.GetAsync<PagedResult<MovieObject>>($"/3/movie/{movieId}/similar", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get a list of movies ordered by rating.
    /// </summary>
    /// <param name="region">ISO-3166-1 code</param>
    public Task<Response<PagedResult<MovieObject>>> GetTopRatedAsync(int page = 1, string language = "en-US", string region = null, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "language", language },
            { "region", region }
        };

        return _client.GetAsync<PagedResult<MovieObject>>("/3/movie/top_rated", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get the translations for a movie.
    /// </summary>
    public Task<Response<TranslationsResponse>> GetTranslationsAsync(int movieId, CancellationToken cancellationToken = default) =>
        _client.GetAsync<TranslationsResponse>($"/3/movie/{movieId}/translations", null, cancellationToken);

    /// <summary>
    /// Get a list of movies that are being released soon.
    /// </summary>
    /// <param name="region">ISO-3166-1 code</param>
    public Task<Response<PagedResultWithDateRange<MovieObject>>> GetUpcomingAsync(int page = 1, string language = "en-US", string region = null, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "language", language },
            { "region", region }
        };

        return _client.GetAsync<PagedResultWithDateRange<MovieObject>>("/3/movie/upcoming", queryParams, cancellationToken);
    }

    public Task<Response<ListResultWithId<VideosResponse>>> GetVideosAsync(int movieId, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "language", language }
        };

        return _client.GetAsync<ListResultWithId<VideosResponse>>($"/3/movie/{movieId}/videos", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get the list of streaming providers we have for a movie.
    /// </summary>
    public Task<Response<ListResultWithId<WatchProvidersResponse>>> GetWatchProvidersAsync(int movieId, CancellationToken cancellationToken = default) =>
        _client.GetAsync<ListResultWithId<WatchProvidersResponse>>($"/3/movie/{movieId}/watch/providers", null, cancellationToken);
}
