using DustyPig.TMDB.Interfaces;
using DustyPig.TMDB.Models.Common;
using DustyPig.TMDB.Models.TvSeries;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Clients;

internal class TvSeriesClient : ITvSeries
{
    private readonly Client _client;

    internal TvSeriesClient(Client client) => _client = client;


    /// <summary>
    /// Get the rating, watchlist and favourite status.
    /// </summary>
    public Task<Response<CommonAccountState>> GetAccountStatesAsync(int seriesId, string guestSessionId = null, string sessionId = null, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "guest_session_id", guestSessionId },
            { "session_id", sessionId }
        };

        return _client.GetAsync<CommonAccountState>($"/3/tv/{seriesId}/account_states", queryParams, cancellationToken);
    }

    /// <summary>
    /// Rate a TV show and save it to your rated list.
    /// </summary>
    public Task<Response<CommonStatus>> AddRatingAsync(CommonValue1 postData, int seriesId, string guestSessionId = null, string sessionId = null, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "guest_session_id", guestSessionId },
            { "session_id", sessionId }
        };

        return _client.PostAsync<CommonStatus>($"/3/tv/{seriesId}/rating", queryParams, postData, cancellationToken);
    }

    /// <summary>
    /// Get the aggregate credits (cast and crew) that have been added to a TV show.
    /// </summary>
    public Task<Response<AggregateCredits>> GetAggregateCreditsAsync(int seriesId, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "language", language }
        };

        return _client.GetAsync<AggregateCredits>($"/3/tv/{seriesId}/aggregate_credits", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get the alternative titles that have been added to a TV show.
    /// </summary>
    public Task<Response<ListResultWithId<CommonTitle>>> GetAlternativeTitlesAsync(int seriesId, CancellationToken cancellationToken = default) =>
        _client.GetAsync<ListResultWithId<CommonTitle>>($"/3/tv/{seriesId}/alternative_titles", null, cancellationToken);

    /// <summary>
    /// Get the recent changes for a TV show.
    /// </summary>
    public Task<Response<CommonChanges>> GetChangesAsync(int seriesId, int page = 1, DateOnly? endDate = null, DateOnly? startDate = null, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "end_date", endDate.DateOnlyToTmdb() },
            { "start_date", startDate.DateOnlyToTmdb() }
        };

        return _client.GetAsync<CommonChanges>($"/3/tv/{seriesId}/changes", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get the content ratings that have been added to a TV show.
    /// </summary>
    public Task<Response<ListResultWithId<ContentRating>>> GetContentRatingsAsync(int seriesId, CancellationToken cancellationToken = default) =>
        _client.GetAsync<ListResultWithId<ContentRating>>($"/3/tv/{seriesId}/content_ratings", null, cancellationToken);

    /// <summary>
    /// Get the latest season credits of a TV show.
    /// </summary>
    public Task<Response<Credits>> GetCreditsAsync(int seriesId, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "language", language }
        };

        return _client.GetAsync<Credits>($"/3/tv/{seriesId}/credits", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get the details of a TV show.
    /// </summary>
    /// <param name="appendToResponse">Info from endpoints in this namespace to add to the response. 20 values max.</param>
    public Task<Response<Details>> GetDetailsAsync(int seriesId, AppendToResponse? appendToResponse = null, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "append_to_response", appendToResponse?.GetEnumDescription() },
            { "language", language }
        };

        return _client.GetAsync<Details>($"/3/tv/{seriesId}", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get the episode groups that have been added to a TV show.
    /// </summary>
    public Task<Response<ListResultWithId<EpisodeGroup>>> GetEpisodeGroupsAsync(int seriesId, CancellationToken cancellationToken = default) =>
        _client.GetAsync<ListResultWithId<EpisodeGroup>>($"/3/tv/{seriesId}/episode_groups", null, cancellationToken);

    /// <summary>
    /// Get a list of external IDs that have been added to a TV show.
    /// </summary>
    public Task<Response<CommonExternalIds>> GetExternalIdsAsync(int seriesId, CancellationToken cancellationToken = default) =>
        _client.GetAsync<CommonExternalIds>($"/3/tv/{seriesId}/external_ids", null, cancellationToken);

    /// <summary>
    /// Get the images that belong to a TV series.
    /// </summary>
    /// <param name="includeImageLanguage">specify a comma separated list of ISO-639-1 values to query, for example: `en,null`</param>
    public Task<Response<CommonImages2>> GetImagesAsync(int seriesId, string includeImageLanguage = null, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "include_image_language", includeImageLanguage },
            { "language", language }
        };

        return _client.GetAsync<CommonImages2>($"/3/tv/{seriesId}/images", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get a list of keywords that have been added to a TV show.
    /// </summary>
    public Task<Response<ListResultWithId<CommonName>>> GetKeywordsAsync(int seriesId, CancellationToken cancellationToken = default) =>
        _client.GetAsync<ListResultWithId<CommonName>>($"/3/tv/{seriesId}/keywords", null, cancellationToken);

    /// <summary>
    /// Get the newest TV show ID.
    /// </summary>
    public Task<Response<Latest>> GetLatestAsync(CancellationToken cancellationToken = default) =>
        _client.GetAsync<Latest>("/3/tv/latest", null, cancellationToken);

    /// <summary>
    /// Get the lists that a TV series has been added to.
    /// </summary>
    public Task<Response<PagedResultWithId<Lists>>> GetListsAsync(int seriesId, int page = 1, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "language", language }
        };

        return _client.GetAsync<PagedResultWithId<Lists>>($"/3/tv/{seriesId}/lists", queryParams, cancellationToken);
    }

    public Task<Response<PagedResult<CommonTvSeries3>>> GetRecommendationsAsync(int seriesId, int page = 1, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "language", language }
        };

        return _client.GetAsync<PagedResult<CommonTvSeries3>>($"/3/tv/{seriesId}/recommendations", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get the reviews that have been added to a TV show.
    /// </summary>
    public Task<Response<PagedResultWithId<Review>>> GetReviewsAsync(int seriesId, int page = 1, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "language", language }
        };

        return _client.GetAsync<PagedResultWithId<Review>>($"/3/tv/{seriesId}/reviews", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get the seasons and episodes that have screened theatrically.
    /// </summary>
    public Task<Response<ListResultWithId<ScreenedTheatrically>>> GetScreenedTheatricallyAsync(int seriesId, CancellationToken cancellationToken = default) =>
        _client.GetAsync<ListResultWithId<ScreenedTheatrically>>($"/3/tv/{seriesId}/screened_theatrically", null, cancellationToken);

    /// <summary>
    /// Get the similar TV shows.
    /// </summary>
    public Task<Response<PagedResult<CommonTvSeries1>>> GetSimilarAsync(int seriesId, int page = 1, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "language", language }
        };

        return _client.GetAsync<PagedResult<CommonTvSeries1>>($"/3/tv/{seriesId}/similar", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get the translations that have been added to a TV show.
    /// </summary>
    public Task<Response<CommonTranslationList<Translation>>> GetTranslationsAsync(int seriesId, CancellationToken cancellationToken = default) =>
        _client.GetAsync<CommonTranslationList<Translation>>($"/3/tv/{seriesId}/translations", null, cancellationToken);

    /// <summary>
    /// Get the videos that belong to a TV show.
    /// </summary>
    /// <param name="includeVideoLanguage">filter the list results by language, supports more than one value by using a comma</param>
    public Task<Response<ListResultWithId<CommonVideo>>> GetVideosAsync(int seriesId, string includeVideoLanguage = null, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "include_video_language", includeVideoLanguage },
            { "language", language }
        };

        return _client.GetAsync<ListResultWithId<CommonVideo>>($"/3/tv/{seriesId}/videos", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get the list of streaming providers we have for a TV show.
    /// </summary>
    public Task<Response<CommonWatchProviderDictionary>> GetWatchProvidersAsync(int seriesId, CancellationToken cancellationToken = default) =>
        _client.GetAsync<CommonWatchProviderDictionary>($"/3/tv/{seriesId}/watch/providers", null, cancellationToken);
}
