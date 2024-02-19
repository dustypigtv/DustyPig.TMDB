using DustyPig.REST;
using DustyPig.TMDB.Models;
using DustyPig.TMDB.Models.Account;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Interfaces;

public interface IAccount
{
    public Task<Response<AddFavoriteResponse>> AddFavoriteAsync(AddFavoriteRequest postData, int accountId, string sessionId = null, CancellationToken cancellationToken = default);

    public Task<Response<AddToWatchlistResponse>> AddToWatchlistAsync(AddToWatchlistRequest postData, int accountId, string sessionId = null, CancellationToken cancellationToken = default);

    public Task<Response<AccountDetails>> GetDetailsAsync(int accountId, string sessionId = null, CancellationToken cancellationToken = default);

    public Task<Response<PagedResult<FavoriteMoviesResponse>>> GetFavoriteMoviesAsync(int accountId, int page = 1, string language = "en-US", string sessionId = null, Sortby sortBy = Sortby.CreatedAtAsc, CancellationToken cancellationToken = default);

    public Task<Response<PagedResult<FavoriteTvResponse>>> GetFavoriteTvAsync(int accountId, int page = 1, string language = "en-US", string sessionId = null, Sortby sortBy = Sortby.CreatedAtAsc, CancellationToken cancellationToken = default);

    public Task<Response<PagedResult<ListsResponse>>> GetListsAsync(int accountId, int page = 1, string sessionId = null, CancellationToken cancellationToken = default);

    public Task<Response<PagedResult<RatedMoviesResponse>>> GetRatedMoviesAsync(int accountId, int page = 1, string language = "en-US", string sessionId = null, Sortby sortBy = Sortby.CreatedAtAsc, CancellationToken cancellationToken = default);

    public Task<Response<PagedResult<RatedTvResponse>>> GetRatedTvAsync(int accountId, int page = 1, string language = "en-US", string sessionId = null, Sortby sortBy = Sortby.CreatedAtAsc, CancellationToken cancellationToken = default);

    public Task<Response<PagedResult<RatedTvEpisodesResponse>>> GetRatedTvEpisodesAsync(int accountId, int page = 1, string language = "en-US", string sessionId = null, Sortby sortBy = Sortby.CreatedAtAsc, CancellationToken cancellationToken = default);

    public Task<Response<PagedResult<WatchlistMoviesResponse>>> GetWatchlistMoviesAsync(int accountId, int page = 1, string language = "en-US", string sessionId = null, Sortby sortBy = Sortby.CreatedAtAsc, CancellationToken cancellationToken = default);

    public Task<Response<PagedResult<WatchlistTvResponse>>> GetWatchlistTvAsync(int accountId, int page = 1, string language = "en-US", string sessionId = null, Sortby sortBy = Sortby.CreatedAtAsc, CancellationToken cancellationToken = default);
}
