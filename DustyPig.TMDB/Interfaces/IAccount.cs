using DustyPig.REST;
using DustyPig.TMDB.Models;
using DustyPig.TMDB.Models.Account;
using DustyPig.TMDB.Models.Common;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Interfaces;

public interface IAccount
{
    public Task<Response<CommonStatus>> AddFavoriteAsync(AddFavorite postData, int accountId, string sessionId = null, CancellationToken cancellationToken = default);

    public Task<Response<CommonStatus>> AddToWatchlistAsync(AddToWatchlist postData, int accountId, string sessionId = null, CancellationToken cancellationToken = default);

    public Task<Response<Details>> GetDetailsAsync(string sessionId = null, CancellationToken cancellationToken = default);

    public Task<Response<PagedResult<Movie>>> GetFavoriteMoviesAsync(int accountId, int page = 1, string language = "en-US", string sessionId = null, CommonSortByCreated sortBy = CommonSortByCreated.CreatedAtAsc, CancellationToken cancellationToken = default);

    public Task<Response<PagedResult<Series>>> GetFavoriteTvSeriesAsync(int accountId, int page = 1, string language = "en-US", string sessionId = null, CommonSortByCreated sortBy = CommonSortByCreated.CreatedAtAsc, CancellationToken cancellationToken = default);

    public Task<Response<PagedResult<CommonList>>> GetListsAsync(int accountId, int page = 1, string sessionId = null, CancellationToken cancellationToken = default);

    public Task<Response<PagedResult<Movie>>> GetRatedMoviesAsync(int accountId, int page = 1, string language = "en-US", string sessionId = null, CommonSortByCreated sortBy = CommonSortByCreated.CreatedAtAsc, CancellationToken cancellationToken = default);

    public Task<Response<PagedResult<Series>>> GetRatedTvSeriesAsync(int accountId, int page = 1, string language = "en-US", string sessionId = null, CommonSortByCreated sortBy = CommonSortByCreated.CreatedAtAsc, CancellationToken cancellationToken = default);

    public Task<Response<PagedResult<CommonRatedTvEpisode>>> GetRatedTvEpisodesAsync(int accountId, int page = 1, string language = "en-US", string sessionId = null, CommonSortByCreated sortBy = CommonSortByCreated.CreatedAtAsc, CancellationToken cancellationToken = default);

    public Task<Response<PagedResult<Movie>>> GetWatchlistMoviesAsync(int accountId, int page = 1, string language = "en-US", string sessionId = null, CommonSortByCreated sortBy = CommonSortByCreated.CreatedAtAsc, CancellationToken cancellationToken = default);

    public Task<Response<PagedResult<Series>>> GetWatchlistTvSeriesAsync(int accountId, int page = 1, string language = "en-US", string sessionId = null, CommonSortByCreated sortBy = CommonSortByCreated.CreatedAtAsc, CancellationToken cancellationToken = default);
}
