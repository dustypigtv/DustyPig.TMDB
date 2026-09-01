using DustyPig.REST;
using DustyPig.TMDB.Models;
using DustyPig.TMDB.Models.Common;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Interfaces;

public interface IGuestSessions
{
    /// <summary>
    /// Get the rated movies for a guest session.
    /// </summary>
    //public Task<Response<PagedResult<CommonMedia>>> GetRatedMoviesAsync(string guestSessionId, int page = 1, string language = "en-US", CommonSortByCreated sortBy = CommonSortByCreated.CreatedAtAsc, CancellationToken cancellationToken = default);
    public Task<Response<PagedResult<Movie>>> GetRatedMoviesAsync(string guestSessionId, int page = 1, string language = "en-US", CommonSortByCreated sortBy = CommonSortByCreated.CreatedAtAsc, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the rated TV shows for a guest session.
    /// </summary>
    //public Task<Response<PagedResult<CommonMedia>>> GetRatedTvSeriesAsync(string guestSessionId, int page = 1, string language = "en-US", CommonSortByCreated sortBy = CommonSortByCreated.CreatedAtAsc, CancellationToken cancellationToken = default);
    public Task<Response<PagedResult<Series>>> GetRatedTvSeriesAsync(string guestSessionId, int page = 1, string language = "en-US", CommonSortByCreated sortBy = CommonSortByCreated.CreatedAtAsc, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the rated TV episodes for a guest session.
    /// </summary>
    public Task<Response<PagedResult<CommonRatedTvEpisode>>> GetRatedTvEpisodesAsync(string guestSessionId, int page = 1, string language = "en-US", CommonSortByCreated sortBy = CommonSortByCreated.CreatedAtAsc, CancellationToken cancellationToken = default);
}
