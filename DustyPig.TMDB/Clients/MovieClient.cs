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
    public Task<Response<CommonAccountState>> GetAccountStatesAsync(int movieId, string guestSessionId = null, string sessionId = null, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "guest_session_id", guestSessionId },
            { "session_id", sessionId }
        };

        return _client.GetAsync<CommonAccountState>($"/3/movie/{movieId}/account_states", queryParams, cancellationToken);
    }

    /// <summary>
    /// Rate a movie and save it to your rated list.
    /// </summary>
    public Task<Response<CommonStatus>> AddRatingAsync(CommonValue1 postData, int movieId, string guestSessionId = null, string sessionId = null, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "guest_session_id", guestSessionId },
            { "session_id", sessionId }
        };

        return _client.PostAsync<CommonStatus>($"/3/movie/{movieId}/rating", queryParams, postData, cancellationToken);
    }

    /// <summary>
    /// Get the alternative titles for a movie.
    /// </summary>
    /// <param name="country">specify a ISO-3166-1 value to filter the results</param>
    public Task<Response<AlternativeTitle>> GetAlternativeTitlesAsync(int movieId, string country = null, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "country", country }
        };

        return _client.GetAsync<AlternativeTitle>($"/3/movie/{movieId}/alternative_titles", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get the recent changes for a movie.
    /// </summary>
    public Task<Response<CommonChanges>> GetChangesAsync(int movieId, int page = 1, DateOnly? endDate = null, DateOnly? startDate = null, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "end_date", endDate.DateOnlyToTmdb() },
            { "start_date", startDate.DateOnlyToTmdb() }
        };

        return _client.GetAsync<CommonChanges>($"/3/movie/{movieId}/changes", queryParams, cancellationToken);
    }

    public Task<Response<Credits>> GetCreditsAsync(int movieId, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "language", language }
        };

        return _client.GetAsync<Credits>($"/3/movie/{movieId}/credits", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get the top level details of a movie by ID.
    /// </summary>
    /// <param name="appendToResponse">Info from endpoints in this namespace to add to the response. 20 values max.</param>
    public Task<Response<Details>> GetDetailsAsync(int movieId, AppendToResponse? appendToResponse = null, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "append_to_response", appendToResponse?.GetEnumDescription() },
            { "language", language }
        };

        return _client.GetAsync<Details>($"/3/movie/{movieId}", queryParams, cancellationToken);
    }

    public Task<Response<ExternalIds>> GetExternalIdsAsync(int movieId, CancellationToken cancellationToken = default) =>
        _client.GetAsync<ExternalIds>($"/3/movie/{movieId}/external_ids", null, cancellationToken);

    /// <summary>
    /// Get the images that belong to a movie.
    /// </summary>
    /// <param name="includeImageLanguage">specify a comma separated list of ISO-639-1 values to query, for example: `en,null`</param>

    /* Unmerged change from project 'DustyPig.TMDB (net7.0)'
    Before:
        public Task<Response<Models.Movie.CommonImages2>> GetImagesAsync(int movieId, string includeImageLanguage = null, string language = "en-US", CancellationToken cancellationToken = default)
    After:
        public Task<Response<CommonImages2>> GetImagesAsync(int movieId, string includeImageLanguage = null, string language = "en-US", CancellationToken cancellationToken = default)
    */
    public Task<Response<Models.Common.CommonImages2>> GetImagesAsync(int movieId, string includeImageLanguage = null, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "include_image_language", includeImageLanguage },
            { "language", language }
        };


        /* Unmerged change from project 'DustyPig.TMDB (net7.0)'
        Before:
                return _client.GetAsync<Models.Movie.CommonImages2>($"/3/movie/{movieId}/images", queryParams, cancellationToken);
        After:
                return _client.GetAsync<CommonImages2>($"/3/movie/{movieId}/images", queryParams, cancellationToken);
        */
        return _client.GetAsync<Models.Common.CommonImages2>($"/3/movie/{movieId}/images", queryParams, cancellationToken);
    }

    public Task<Response<KeywordsList>> GetKeywordsAsync(string movieId, CancellationToken cancellationToken = default) =>
        _client.GetAsync<KeywordsList>($"/3/movie/{movieId}/keywords", null, cancellationToken);

    /// <summary>
    /// Get the newest movie ID.
    /// </summary>
    public Task<Response<Latest>> GetLatestAsync(CancellationToken cancellationToken = default) =>
        _client.GetAsync<Latest>("/3/movie/latest", null, cancellationToken);

    /// <summary>
    /// Get the lists that a movie has been added to.
    /// </summary>
    public Task<Response<PagedResultWithId<CommonList>>> GetListsAsync(int movieId, int page = 1, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "language", language }
        };

        return _client.GetAsync<PagedResultWithId<CommonList>>($"/3/movie/{movieId}/lists", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get a list of movies that are currently in theatres.
    /// </summary>
    /// <param name="region">ISO-3166-1 code</param>
    public Task<Response<PagedResultWithDateRange<CommonMovie>>> GetNowPlayingAsync(int page = 1, string language = "en-US", string region = null, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "language", language },
            { "region", region }
        };

        return _client.GetAsync<PagedResultWithDateRange<CommonMovie>>("/3/movie/now_playing", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get a list of movies ordered by popularity.
    /// </summary>
    /// <param name="region">ISO-3166-1 code</param>
    public Task<Response<PagedResult<CommonMovie>>> GetPopularAsync(int page = 1, string language = "en-US", string region = null, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "language", language },
            { "region", region }
        };

        return _client.GetAsync<PagedResult<CommonMovie>>("/3/movie/popular", queryParams, cancellationToken);
    }

    public Task<Response<PagedResult<CommonMedia>>> GetRecommendationsAsync(int movieId, int page = 1, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "language", language }
        };

        return _client.GetAsync<PagedResult<CommonMedia>>($"/3/movie/{movieId}/recommendations", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get the release dates and certifications for a movie.
    /// </summary>
    public Task<Response<ListResultWithId<Releases>>> GetReleaseDatesAsync(int movieId, CancellationToken cancellationToken = default) =>
        _client.GetAsync<ListResultWithId<Releases>>($"/3/movie/{movieId}/release_dates", null, cancellationToken);

    /// <summary>
    /// Get the user reviews for a movie.
    /// </summary>
    public Task<Response<PagedResultWithId<Reviews>>> GetReviewsAsync(int movieId, int page = 1, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "language", language }
        };

        return _client.GetAsync<PagedResultWithId<Reviews>>($"/3/movie/{movieId}/reviews", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get the similar movies based on genres and keywords.
    /// </summary>
    public Task<Response<PagedResult<CommonMovie>>> GetSimilarAsync(int movieId, int page = 1, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "language", language }
        };

        return _client.GetAsync<PagedResult<CommonMovie>>($"/3/movie/{movieId}/similar", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get a list of movies ordered by rating.
    /// </summary>
    /// <param name="region">ISO-3166-1 code</param>
    public Task<Response<PagedResult<CommonMovie>>> GetTopRatedAsync(int page = 1, string language = "en-US", string region = null, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "language", language },
            { "region", region }
        };

        return _client.GetAsync<PagedResult<CommonMovie>>("/3/movie/top_rated", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get the translations for a movie.
    /// </summary>
    public Task<Response<CommonTranslationList<Translation>>> GetTranslationsAsync(int movieId, CancellationToken cancellationToken = default) =>
        _client.GetAsync<CommonTranslationList<Translation>>($"/3/movie/{movieId}/translations", null, cancellationToken);

    /// <summary>
    /// Get a list of movies that are being released soon.
    /// </summary>
    /// <param name="region">ISO-3166-1 code</param>
    public Task<Response<PagedResultWithDateRange<CommonMovie>>> GetUpcomingAsync(int page = 1, string language = "en-US", string region = null, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "language", language },
            { "region", region }
        };

        return _client.GetAsync<PagedResultWithDateRange<CommonMovie>>("/3/movie/upcoming", queryParams, cancellationToken);
    }

    public Task<Response<ListResultWithId<CommonVideo>>> GetVideosAsync(int movieId, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "language", language }
        };

        return _client.GetAsync<ListResultWithId<CommonVideo>>($"/3/movie/{movieId}/videos", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get the list of streaming providers we have for a movie.
    /// </summary>
    public Task<Response<ListResultWithId<CommonWatchProvider>>> GetWatchProvidersAsync(int movieId, CancellationToken cancellationToken = default) =>
        _client.GetAsync<ListResultWithId<CommonWatchProvider>>($"/3/movie/{movieId}/watch/providers", null, cancellationToken);
}
