using DustyPig.TMDB.Models.Common;
using DustyPig.TMDB.Models.Trending;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Interfaces;

public interface ITrending
{
    /// <summary>
    /// Get the trending movies, TV shows and people.
    /// </summary>
    /// <param name="language">`ISO-639-1`-`ISO-3166-1` code</param>
    public Task<Response<PagedResult<CommonMedia>>> GetAllAsync(Timewindow timeWindow = Timewindow.Day, string language = "en-US", CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the trending movies on TMDB.
    /// </summary>
    /// <param name="language">`ISO-639-1`-`ISO-3166-1` code</param>
    public Task<Response<PagedResult<CommonMedia>>> GetMoviesAsync(Timewindow timeWindow = Timewindow.Day, string language = "en-US", CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the trending people on TMDB.
    /// </summary>
    /// <param name="language">`ISO-639-1`-`ISO-3166-1` code</param>
    public Task<Response<PagedResult<Person>>> GetPeopleAsync(Timewindow timeWindow = Timewindow.Day, string language = "en-US", CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the trending TV shows on TMDB.
    /// </summary>
    /// <param name="language">`ISO-639-1`-`ISO-3166-1` code</param>
    public Task<Response<PagedResult<CommonTvSeries3>>> GetTvSeriesAsync(Timewindow timeWindow = Timewindow.Day, string language = "en-US", CancellationToken cancellationToken = default);
}
