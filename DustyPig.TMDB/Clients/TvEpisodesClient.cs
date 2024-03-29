using DustyPig.REST;
using DustyPig.TMDB.Interfaces;
using DustyPig.TMDB.Models.Common;
using DustyPig.TMDB.Models.TvEpisodes;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Clients;

internal class TvEpisodesClient : ITvEpisodes
{
    private readonly Client _client;

    internal TvEpisodesClient(Client client) => _client = client;


    /// <summary>
    /// Get the rating, watchlist and favourite status.
    /// </summary>
    public Task<Response<CommonAccountState>> GetAccountStatesAsync(int episodeNumber, int seasonNumber, int seriesId, string guestSessionId = null, string sessionId = null, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "guest_session_id", guestSessionId },
            { "session_id", sessionId }
        };

        return _client.GetAsync<CommonAccountState>($"/3/tv/{seriesId}/season/{seasonNumber}/episode/{episodeNumber}/account_states", queryParams, cancellationToken);
    }

    /// <summary>
    /// Rate a TV episode and save it to your rated list.
    /// </summary>
    public Task<Response<CommonStatus>> AddRatingAsync(float rating, int episodeNumber, int seasonNumber, int seriesId, string guestSessionId = null, string sessionId = null, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "guest_session_id", guestSessionId },
            { "session_id", sessionId }
        };

        var postData = new FloatValueWrapper(rating);

        return _client.PostAsync<CommonStatus>($"/3/tv/{seriesId}/season/{seasonNumber}/episode/{episodeNumber}/rating", queryParams, postData, cancellationToken);
    }

    /// <summary>
    /// Delete your rating on a TV episode.
    /// </summary>
    public Task<Response<CommonStatus>> DeleteRatingAsync(int episodeNumber, int seasonNumber, int seriesId, string guestSessionId = null, string sessionId = null, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "guest_session_id", guestSessionId },
            { "session_id", sessionId }
        };

        return _client.DeleteAsync<CommonStatus>($"/3/tv/{seriesId}/season/{seasonNumber}/episode/{episodeNumber}/rating", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get the recent changes for a TV episode.
    /// </summary>
    public Task<Response<ChangeList>> GetChangesAsync(int episodeId, CancellationToken cancellationToken = default) =>
        _client.GetAsync<ChangeList>($"/3/tv/episode/{episodeId}/changes", null, cancellationToken);

    public Task<Response<Credits>> GetCreditsAsync(int episodeNumber, int seasonNumber, int seriesId, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "language", language }
        };

        return _client.GetAsync<Credits>($"/3/tv/{seriesId}/season/{seasonNumber}/episode/{episodeNumber}/credits", queryParams, cancellationToken);
    }

    /// <summary>
    /// Query the details of a TV episode.
    /// </summary>
    /// <param name="appendToResponse">Info from endpoints in this namespace to add to the response. 20 values max.</param>
    public Task<Response<Details>> GetDetailsAsync(int episodeNumber, int seasonNumber, int seriesId, AppendToResponse? appendToResponse = null, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "append_to_response", appendToResponse?.GetEnumDescription() },
            { "language", language }
        };

        return _client.GetAsync<Details>($"/3/tv/{seriesId}/season/{seasonNumber}/episode/{episodeNumber}", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get a list of external IDs that have been added to a TV episode.
    /// </summary>
    public Task<Response<CommonExternalIds>> GetExternalIdsAsync(int episodeNumber, int seasonNumber, int seriesId, CancellationToken cancellationToken = default) =>
        _client.GetAsync<CommonExternalIds>($"/3/tv/{seriesId}/season/{seasonNumber}/episode/{episodeNumber}/external_ids", null, cancellationToken);

    /// <summary>
    /// Get the images that belong to a TV episode.
    /// </summary>
    /// <param name="includeImageLanguage">specify a comma separated list of ISO-639-1 values to query, for example: `en,null`</param>
    public Task<Response<Images>> GetImagesAsync(int episodeNumber, int seasonNumber, int seriesId, string includeImageLanguage = null, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "include_image_language", includeImageLanguage },
            { "language", language }
        };

        return _client.GetAsync<Images>($"/3/tv/{seriesId}/season/{seasonNumber}/episode/{episodeNumber}/images", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get the translations that have been added to a TV episode.
    /// </summary>
    public Task<Response<CommonTranslationList<CommonTranslationData>>> GetTranslationsAsync(int episodeNumber, int seasonNumber, int seriesId, CancellationToken cancellationToken = default) =>
        _client.GetAsync<CommonTranslationList<CommonTranslationData>>($"/3/tv/{seriesId}/season/{seasonNumber}/episode/{episodeNumber}/translations", null, cancellationToken);

    /// <summary>
    /// Get the videos that belong to a TV episode.
    /// </summary>
    /// <param name="includeVideoLanguage">filter the list results by language, supports more than one value by using a comma</param>
    public Task<Response<ListResultWithId<CommonVideo>>> GetVideosAsync(int episodeNumber, int seasonNumber, int seriesId, string includeVideoLanguage = null, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "include_video_language", includeVideoLanguage },
            { "language", language }
        };

        return _client.GetAsync<ListResultWithId<CommonVideo>>($"/3/tv/{seriesId}/season/{seasonNumber}/episode/{episodeNumber}/videos", queryParams, cancellationToken);
    }
}
