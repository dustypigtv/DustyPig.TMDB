using DustyPig.REST;
using DustyPig.TMDB.Enums;
using DustyPig.TMDB.Models.Common;
using DustyPig.TMDB.Models.Movies;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Clients;

public class MoviesClient
{
    private readonly Client _client;

    internal MoviesClient(Client client) => _client = client;


    /// <summary>
    /// Get the rating, watchlist and favourite status of an account.
    /// </summary>
    public Task<Response<AccountState>> GetAccountStatesAsync(int movieId, string guestSessionId = null, string sessionId = null, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "guest_session_id", guestSessionId },
            { "session_id", sessionId }
        };

        return _client.GetAsync<AccountState>($"/3/movie/{movieId}/account_states", queryParams, cancellationToken);
    }

    /// <summary>
    /// Rate a movie and save it to your rated list.
    /// </summary>
    public Task<Response<StatusResponse>> AddRatingAsync(float rating, int movieId, string guestSessionId = null, string sessionId = null, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "guest_session_id", guestSessionId },
            { "session_id", sessionId }
        };

        var postData = new FloatValueWrapper(rating);

        return _client.PostAsync<StatusResponse>($"/3/movie/{movieId}/rating", queryParams, postData, cancellationToken);
    }

    /// <summary>
    /// Delete a user rating.
    /// </summary>
    /// <returns></returns>
    public Task<Response<StatusResponse>> DeleteRatingAsync(int movieId, string guestSessionId = null, string sessionId = null, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "guest_session_id", guestSessionId },
            { "session_id", sessionId }
        };

        return _client.DeleteAsync<StatusResponse>($"/3/movie/{movieId}/rating", queryParams, cancellationToken);
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
    public Task<Response<ChangesList>> GetChangesAsync(int movieId, int page = 1, DateOnly? endDate = null, DateOnly? startDate = null, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "end_date", endDate.DateOnlyToTmdb() },
            { "start_date", startDate.DateOnlyToTmdb() }
        };

        return _client.GetAsync<ChangesList>($"/3/movie/{movieId}/changes", queryParams, cancellationToken);
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
    public Task<Response<Details>> GetDetailsAsync(int movieId, MovieAppendToResponse? appendToResponse = null, string language = "en-US", CancellationToken cancellationToken = default)
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
    public Task<Response<Images>> GetImagesAsync(int movieId, string includeImageLanguage = null, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "include_image_language", includeImageLanguage },
            { "language", language }
        };

        return _client.GetAsync<Images>($"/3/movie/{movieId}/images", queryParams, cancellationToken);
    }

    public Task<Response<KeywordsList>> GetKeywordsAsync(int movieId, CancellationToken cancellationToken = default) =>
        _client.GetAsync<KeywordsList>($"/3/movie/{movieId}/keywords", null, cancellationToken);

    /// <summary>
    /// Get the newest movie ID.
    /// </summary>
    public Task<Response<Details>> GetLatestAsync(CancellationToken cancellationToken = default) =>
        _client.GetAsync<Details>("/3/movie/latest", null, cancellationToken);

    /// <summary>
    /// Get the lists that a movie has been added to.
    /// </summary>
    public Task<Response<PagedResultWithId<MediaList>>> GetListsAsync(int movieId, int page = 1, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "language", language }
        };

        return _client.GetAsync<PagedResultWithId<MediaList>>($"/3/movie/{movieId}/lists", queryParams, cancellationToken);
    }

    public Task<Response<PagedResult<Movie>>> GetRecommendationsAsync(int movieId, int page = 1, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "language", language }
        };

        return _client.GetAsync<PagedResult<Movie>>($"/3/movie/{movieId}/recommendations", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get the release dates and certifications for a movie.
    /// </summary>
    public Task<Response<ListResultWithId<Releases>>> GetReleaseDatesAsync(int movieId, CancellationToken cancellationToken = default) =>
        _client.GetAsync<ListResultWithId<Releases>>($"/3/movie/{movieId}/release_dates", null, cancellationToken);

    /// <summary>
    /// Get the user reviews for a movie.
    /// </summary>
    public Task<Response<PagedResultWithId<Review>>> GetReviewsAsync(int movieId, int page = 1, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "language", language }
        };

        return _client.GetAsync<PagedResultWithId<Review>>($"/3/movie/{movieId}/reviews", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get the similar movies based on genres and keywords.
    /// </summary>
    public Task<Response<PagedResult<Movie>>> GetSimilarAsync(int movieId, int page = 1, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "language", language }
        };

        return _client.GetAsync<PagedResult<Movie>>($"/3/movie/{movieId}/similar", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get the translations for a movie.
    /// </summary>
    public Task<Response<TranslationList<TranslationData>>> GetTranslationsAsync(int movieId, CancellationToken cancellationToken = default) =>
        _client.GetAsync<TranslationList<TranslationData>>($"/3/movie/{movieId}/translations", null, cancellationToken);

    public Task<Response<ListResultWithId<Video>>> GetVideosAsync(int movieId, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "language", language }
        };

        return _client.GetAsync<ListResultWithId<Video>>($"/3/movie/{movieId}/videos", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get the list of streaming providers we have for a movie.
    /// </summary>
    public Task<Response<WatchProviderDictionary>> GetWatchProvidersAsync(int movieId, CancellationToken cancellationToken = default) =>
        _client.GetAsync<WatchProviderDictionary>($"/3/movie/{movieId}/watch/providers", null, cancellationToken);
}