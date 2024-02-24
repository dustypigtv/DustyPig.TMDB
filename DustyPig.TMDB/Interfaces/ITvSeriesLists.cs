using DustyPig.TMDB.Models.Common;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Interfaces;

public interface ITvSeriesLists
{
    /// <summary>
    /// Get a list of TV shows airing today.
    /// </summary>
    public Task<Response<PagedResult<CommonTvSeries2>>> GetAiringTodayAsync(int page = 1, string language = "en-US", string timezone = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a list of TV shows that air in the next 7 days.
    /// </summary>
    public Task<Response<PagedResult<CommonTvSeries2>>> GetOnTheAirAsync(int page = 1, string language = "en-US", string timezone = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a list of TV shows ordered by popularity.
    /// </summary>
    public Task<Response<PagedResult<CommonTvSeries2>>> GetPopularAsync(int page = 1, string language = "en-US", CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a list of TV shows ordered by rating.
    /// </summary>
    public Task<Response<PagedResult<CommonTvSeries2>>> GetTopRatedAsync(int page = 1, string language = "en-US", CancellationToken cancellationToken = default);

}