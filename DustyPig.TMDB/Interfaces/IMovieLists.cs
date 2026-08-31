using DustyPig.REST;
using DustyPig.TMDB.Models.Common;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Interfaces;

public interface IMovieLists
{
    /// <summary>
    /// Get a list of movies that are currently in theatres.
    /// </summary>
    /// <param name="region">ISO-3166-1 code</param>
    public Task<Response<PagedResultWithDateRange<CommonMedia>>> GetNowPlayingAsync(int page = 1, string language = "en-US", string region = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a list of movies ordered by popularity.
    /// </summary>
    /// <param name="region">ISO-3166-1 code</param>
    public Task<Response<PagedResult<CommonMedia>>> GetPopularAsync(int page = 1, string language = "en-US", string region = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a list of movies ordered by rating.
    /// </summary>
    /// <param name="region">ISO-3166-1 code</param>
    public Task<Response<PagedResult<CommonMedia>>> GetTopRatedAsync(int page = 1, string language = "en-US", string region = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a list of movies that are being released soon.
    /// </summary>
    /// <param name="region">ISO-3166-1 code</param>
    public Task<Response<PagedResultWithDateRange<CommonMedia>>> GetUpcomingAsync(int page = 1, string language = "en-US", string region = null, CancellationToken cancellationToken = default);
}