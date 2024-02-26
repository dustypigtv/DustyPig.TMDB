using DustyPig.TMDB.Models.Common;
using DustyPig.TMDB.Models.TvEpisodes;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Interfaces;

public interface ITvEpisodes
{
    /// <summary>
    /// Get the rating, watchlist and favourite status.
    /// </summary>
    public Task<Response<CommonAccountState>> GetAccountStatesAsync(int episodeNumber, int seasonNumber, int seriesId, string guestSessionId = null, string sessionId = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Rate a TV episode and save it to your rated list.
    /// </summary>
    public Task<Response<CommonStatus>> AddRatingAsync(float rating, int episodeNumber, int seasonNumber, int seriesId, string guestSessionId = null, string sessionId = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete your rating on a TV episode.
    /// </summary>
    public Task<Response<CommonStatus>> DeleteRatingAsync(int episodeNumber, int seasonNumber, int seriesId, string guestSessionId = null, string sessionId = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the recent changes for a TV episode.
    /// </summary>
    public Task<Response<ChangeList>> GetChangesAsync(int episodeId, CancellationToken cancellationToken = default);

    public Task<Response<Credits>> GetCreditsAsync(int episodeNumber, int seasonNumber, int seriesId, string language = "en-US", CancellationToken cancellationToken = default);

    /// <summary>
    /// Query the details of a TV episode.
    /// </summary>
    /// <param name="appendToResponse">Info from endpoints in this namespace to add to the response. 20 values max.</param>
    public Task<Response<Details>> GetDetailsAsync(int episodeNumber, int seasonNumber, int seriesId, AppendToResponse? appendToResponse = null, string language = "en-US", CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a list of external IDs that have been added to a TV episode.
    /// </summary>
    public Task<Response<CommonExternalIds>> GetExternalIdsAsync(int episodeNumber, int seasonNumber, int seriesId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the images that belong to a TV episode.
    /// </summary>
    /// <param name="includeImageLanguage">specify a comma separated list of ISO-639-1 values to query, for example: `en,null`</param>
    public Task<Response<Images>> GetImagesAsync(int episodeNumber, int seasonNumber, int seriesId, string includeImageLanguage = null, string language = "en-US", CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the translations that have been added to a TV episode.
    /// </summary>
    public Task<Response<CommonTranslationList<CommonTranslationData>>> GetTranslationsAsync(int episodeNumber, int seasonNumber, int seriesId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the videos that belong to a TV episode.
    /// </summary>
    /// <param name="includeVideoLanguage">filter the list results by language, supports more than one value by using a comma</param>
    public Task<Response<ListResultWithId<CommonVideo>>> GetVideosAsync(int episodeNumber, int seasonNumber, int seriesId, string includeVideoLanguage = null, string language = "en-US", CancellationToken cancellationToken = default);
}
