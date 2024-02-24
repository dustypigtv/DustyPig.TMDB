using DustyPig.REST;
using DustyPig.TMDB.Interfaces;
using DustyPig.TMDB.Models.Common;
using DustyPig.TMDB.Models.TvSeason;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Clients;

internal class TvSeasonClient : ITvSeason
{
    private readonly Client _client;

    internal TvSeasonClient(Client client) => _client = client;


    /// <summary>
    /// Get the rating, watchlist and favourite status.
    /// </summary>
    public Task<Response<ListResultWithId<AccountState>>> GetAccountStatesAsync(int seasonNumber, int seriesId, string guestSessionId = null, string sessionId = null, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "guest_session_id", guestSessionId },
            { "session_id", sessionId }
        };

        return _client.GetAsync<ListResultWithId<AccountState>>($"/3/tv/{seriesId}/season/{seasonNumber}/account_states", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get the aggregate credits (cast and crew) that have been added to a TV season.
    /// </summary>
    public Task<Response<AggregateCredits>> GetAggregateCreditsAsync(int seasonNumber, int seriesId, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "language", language }
        };

        return _client.GetAsync<AggregateCredits>($"/3/tv/{seriesId}/season/{seasonNumber}/aggregate_credits", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get the recent changes for a TV season.
    /// </summary>
    public Task<Response<ChangeList>> GetChangesAsync(int seasonId, int page = 1, DateOnly? endDate = null, DateOnly? startDate = null, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "end_date", endDate.DateOnlyToTmdb() },
            { "start_date", startDate.DateOnlyToTmdb() }
        };

        return _client.GetAsync<ChangeList>($"/3/tv/season/{seasonId}/changes", queryParams, cancellationToken);
    }

    public Task<Response<Credits>> GetCreditsAsync(int seasonNumber, int seriesId, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "language", language }
        };

        return _client.GetAsync<Credits>($"/3/tv/{seriesId}/season/{seasonNumber}/credits", queryParams, cancellationToken);
    }

    /// <summary>
    /// Query the details of a TV season.
    /// </summary>
    /// <param name="appendToResponse">Info from endpoints in this namespace to add to the response. 20 values max.</param>
    public Task<Response<Details>> GetDetailsAsync(int seasonNumber, int seriesId, AppendToResponse? appendToResponse = null, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "append_to_response", appendToResponse?.GetEnumDescription() },
            { "language", language }
        };

        return _client.GetAsync<Details>($"/3/tv/{seriesId}/season/{seasonNumber}", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get a list of external IDs that have been added to a TV season.
    /// </summary>
    public Task<Response<ExternalIds>> GetExternalIdsAsync(int seasonNumber, int seriesId, CancellationToken cancellationToken = default) =>
        _client.GetAsync<ExternalIds>($"/3/tv/{seriesId}/season/{seasonNumber}/external_ids", null, cancellationToken);

    /// <summary>
    /// Get the images that belong to a TV season.
    /// </summary>
    /// <param name="includeImageLanguage">specify a comma separated list of ISO-639-1 values to query, for example: `en,null`</param>
    public Task<Response<Images>> GetImagesAsync(int seasonNumber, int seriesId, string includeImageLanguage = null, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "include_image_language", includeImageLanguage },
            { "language", language }
        };

        return _client.GetAsync<Images>($"/3/tv/{seriesId}/season/{seasonNumber}/images", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get the translations for a TV season.
    /// </summary>
    public Task<Response<CommonTranslationList<CommonTranslationData>>> GetTranslationsAsync(int seasonNumber, int seriesId, CancellationToken cancellationToken = default) =>
        _client.GetAsync<CommonTranslationList<CommonTranslationData>>($"/3/tv/{seriesId}/season/{seasonNumber}/translations", null, cancellationToken);

    /// <summary>
    /// Get the videos that belong to a TV season.
    /// </summary>
    /// <param name="includeVideoLanguage">filter the list results by language, supports more than one value by using a comma</param>
    public Task<Response<ListResultWithId<CommonVideo>>> GetVideosAsync(int seasonNumber, int seriesId, string includeVideoLanguage = null, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "include_video_language", includeVideoLanguage },
            { "language", language }
        };

        return _client.GetAsync<ListResultWithId<CommonVideo>>($"/3/tv/{seriesId}/season/{seasonNumber}/videos", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get the list of streaming providers we have for a TV season.
    /// </summary>
    public Task<Response<ListResultWithId<CommonProvider>>> GetWatchProvidersAsync(int seasonNumber, int seriesId, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "language", language }
        };

        return _client.GetAsync<ListResultWithId<CommonProvider>>($"/3/tv/{seriesId}/season/{seasonNumber}/watch/providers", queryParams, cancellationToken);
    }
}
