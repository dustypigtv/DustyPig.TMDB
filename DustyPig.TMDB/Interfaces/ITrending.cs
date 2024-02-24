using DustyPig.REST;
using DustyPig.TMDB.Models;
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
    public Task<Response<PagedResult<MoviesResponse>>> GetAllAsync(Timewindow timeWindow = Timewindow.Day, string language = "en-US", CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the trending movies on TMDB.
    /// </summary>
    /// <param name="language">`ISO-639-1`-`ISO-3166-1` code</param>
    public Task<Response<PagedResult<MoviesResponse>>> GetMoviesAsync(Timewindow timeWindow = Timewindow.Day, string language = "en-US", CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the trending people on TMDB.
    /// </summary>
    /// <param name="language">`ISO-639-1`-`ISO-3166-1` code</param>
    public Task<Response<PagedResult<PeopleResponse>>> GetPeopleAsync(Timewindow timeWindow = Timewindow.Day, string language = "en-US", CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the trending TV shows on TMDB.
    /// </summary>
    /// <param name="language">`ISO-639-1`-`ISO-3166-1` code</param>
    public Task<Response<PagedResult<TvResponse>>> GetTvAsync(Timewindow timeWindow = Timewindow.Day, string language = "en-US", CancellationToken cancellationToken = default);
}
