using DustyPig.REST;
using DustyPig.TMDB.Interfaces;
using DustyPig.TMDB.Models.Common;
using DustyPig.TMDB.Models.TvEpisode;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Clients;

internal class TvEpisodeClient : ITvEpisode
{
    private readonly Client _client;

    internal TvEpisodeClient(Client client) => _client = client;


    /// <summary>
    /// Get the rating, watchlist and favourite status.
    /// </summary>
    public Task<Response<AccountStatesResponse>> GetAccountStatesAsync(int episodeNumber, int seasonNumber, int seriesId, string guestSessionId = null, string sessionId = null, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "guest_session_id", guestSessionId },
            { "session_id", sessionId }
        };

        return _client.GetAsync<AccountStatesResponse>($"/3/tv/{seriesId}/season/{seasonNumber}/episode/{episodeNumber}/account_states", queryParams, cancellationToken);
    }

    /// <summary>
    /// Rate a TV episode and save it to your rated list.
    /// </summary>
    public Task<Response<CommonStatus>> AddRatingAsync(AddRatingRequest postData, int episodeNumber, int seasonNumber, int seriesId, string guestSessionId = null, string sessionId = null, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "guest_session_id", guestSessionId },
            { "session_id", sessionId }
        };

        return _client.PostAsync<CommonStatus>($"/3/tv/{seriesId}/season/{seasonNumber}/episode/{episodeNumber}/rating", queryParams, postData, cancellationToken);
    }

    /// <summary>
    /// Get the recent changes for a TV episode.
    /// </summary>
    public Task<Response<ChangesResponse>> GetChangesAsync(int episodeId, CancellationToken cancellationToken = default) =>
        _client.GetAsync<ChangesResponse>($"/3/tv/episode/{episodeId}/changes", null, cancellationToken);

    public Task<Response<CreditsResponse>> GetCreditsAsync(int episodeNumber, int seasonNumber, int seriesId, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "language", language }
        };

        return _client.GetAsync<CreditsResponse>($"/3/tv/{seriesId}/season/{seasonNumber}/episode/{episodeNumber}/credits", queryParams, cancellationToken);
    }

    /// <summary>
    /// Query the details of a TV episode.
    /// </summary>
    /// <param name="appendToResponse">Info from endpoints in this namespace to add to the response. 20 values max.</param>
    public Task<Response<DetailsResponse>> GetDetailsAsync(int episodeNumber, int seasonNumber, int seriesId, AppendToResponse? appendToResponse = null, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "append_to_response", appendToResponse?.GetEnumDescription() },
            { "language", language }
        };

        return _client.GetAsync<DetailsResponse>($"/3/tv/{seriesId}/season/{seasonNumber}/episode/{episodeNumber}", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get a list of external IDs that have been added to a TV episode.
    /// </summary>
    public Task<Response<ExternalIdsResponse>> GetExternalIdsAsync(string episodeNumber, int seasonNumber, int seriesId, CancellationToken cancellationToken = default) =>
        _client.GetAsync<ExternalIdsResponse>($"/3/tv/{seriesId}/season/{seasonNumber}/episode/{episodeNumber}/external_ids", null, cancellationToken);

    /// <summary>
    /// Get the images that belong to a TV episode.
    /// </summary>
    /// <param name="includeImageLanguage">specify a comma separated list of ISO-639-1 values to query, for example: `en,null`</param>
    public Task<Response<ImagesResponse>> GetImagesAsync(int episodeNumber, int seasonNumber, int seriesId, string includeImageLanguage = null, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "include_image_language", includeImageLanguage },
            { "language", language }
        };

        return _client.GetAsync<ImagesResponse>($"/3/tv/{seriesId}/season/{seasonNumber}/episode/{episodeNumber}/images", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get the translations that have been added to a TV episode.
    /// </summary>
    public Task<Response<CommonTranslations<CommonTranslation>>> GetTranslationsAsync(int episodeNumber, int seasonNumber, int seriesId, CancellationToken cancellationToken = default) =>
        _client.GetAsync<CommonTranslations<CommonTranslation>>($"/3/tv/{seriesId}/season/{seasonNumber}/episode/{episodeNumber}/translations", null, cancellationToken);

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
