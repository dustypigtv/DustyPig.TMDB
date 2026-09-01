using DustyPig.REST;
using DustyPig.TMDB.Models.Account;
using DustyPig.TMDB.Models.Common;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Interfaces;

public interface IAccount
{
    public Task<Response<StatusResponse>> AddFavoriteAsync(AddFavorite postData, int accountId, string sessionId = null, CancellationToken cancellationToken = default);

    public Task<Response<StatusResponse>> AddToWatchlistAsync(AddToWatchlist postData, int accountId, string sessionId = null, CancellationToken cancellationToken = default);

    public Task<Response<Details>> GetDetailsAsync(string sessionId = null, CancellationToken cancellationToken = default);

    public Task<Response<PagedResult<Movie>>> GetFavoriteMoviesAsync(int accountId, int page = 1, string language = "en-US", string sessionId = null, SortByCreated sortBy = SortByCreated.CreatedAtAsc, CancellationToken cancellationToken = default);

    public Task<Response<PagedResult<TvSeries>>> GetFavoriteTvSeriesAsync(int accountId, int page = 1, string language = "en-US", string sessionId = null, SortByCreated sortBy = SortByCreated.CreatedAtAsc, CancellationToken cancellationToken = default);

    public Task<Response<PagedResult<MediaList>>> GetListsAsync(int accountId, int page = 1, string sessionId = null, CancellationToken cancellationToken = default);

    public Task<Response<PagedResult<Movie>>> GetRatedMoviesAsync(int accountId, int page = 1, string language = "en-US", string sessionId = null, SortByCreated sortBy = SortByCreated.CreatedAtAsc, CancellationToken cancellationToken = default);

    public Task<Response<PagedResult<TvSeries>>> GetRatedTvSeriesAsync(int accountId, int page = 1, string language = "en-US", string sessionId = null, SortByCreated sortBy = SortByCreated.CreatedAtAsc, CancellationToken cancellationToken = default);

    public Task<Response<PagedResult<RatedTvEpisode>>> GetRatedTvEpisodesAsync(int accountId, int page = 1, string language = "en-US", string sessionId = null, SortByCreated sortBy = SortByCreated.CreatedAtAsc, CancellationToken cancellationToken = default);

    public Task<Response<PagedResult<Movie>>> GetWatchlistMoviesAsync(int accountId, int page = 1, string language = "en-US", string sessionId = null, SortByCreated sortBy = SortByCreated.CreatedAtAsc, CancellationToken cancellationToken = default);

    public Task<Response<PagedResult<TvSeries>>> GetWatchlistTvSeriesAsync(int accountId, int page = 1, string language = "en-US", string sessionId = null, SortByCreated sortBy = SortByCreated.CreatedAtAsc, CancellationToken cancellationToken = default);
}
