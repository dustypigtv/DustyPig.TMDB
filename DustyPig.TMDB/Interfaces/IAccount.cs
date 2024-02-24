using DustyPig.REST;
using DustyPig.TMDB.Models.Account;
using DustyPig.TMDB.Models.Common;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Interfaces;

public interface IAccount
{
    public Task<Response<CommonStatus>> AddFavoriteAsync(AddFavorite postData, int accountId, string sessionId = null, CancellationToken cancellationToken = default);

    public Task<Response<CommonStatus>> AddToWatchlistAsync(AddToWatchlist postData, int accountId, string sessionId = null, CancellationToken cancellationToken = default);

    public Task<Response<Details>> GetDetailsAsync(int accountId, string sessionId = null, CancellationToken cancellationToken = default);

    public Task<Response<PagedResult<CommonMovie>>> GetFavoriteMoviesAsync(int accountId, int page = 1, string language = "en-US", string sessionId = null, Sortby sortBy = Sortby.CreatedAtAsc, CancellationToken cancellationToken = default);

    public Task<Response<PagedResult<CommonTvSeries1>>> GetFavoriteTvAsync(int accountId, int page = 1, string language = "en-US", string sessionId = null, Sortby sortBy = Sortby.CreatedAtAsc, CancellationToken cancellationToken = default);

    public Task<Response<PagedResult<CommonList>>> GetListsAsync(int accountId, int page = 1, string sessionId = null, CancellationToken cancellationToken = default);

    public Task<Response<PagedResult<RatedMovie>>> GetRatedMoviesAsync(int accountId, int page = 1, string language = "en-US", string sessionId = null, Sortby sortBy = Sortby.CreatedAtAsc, CancellationToken cancellationToken = default);

    public Task<Response<PagedResult<RatedTvSeries>>> GetRatedTvAsync(int accountId, int page = 1, string language = "en-US", string sessionId = null, Sortby sortBy = Sortby.CreatedAtAsc, CancellationToken cancellationToken = default);

    public Task<Response<PagedResult<RatedTvEpisode>>> GetRatedTvEpisodesAsync(int accountId, int page = 1, string language = "en-US", string sessionId = null, Sortby sortBy = Sortby.CreatedAtAsc, CancellationToken cancellationToken = default);

    public Task<Response<PagedResult<CommonMovie>>> GetWatchlistMoviesAsync(int accountId, int page = 1, string language = "en-US", string sessionId = null, Sortby sortBy = Sortby.CreatedAtAsc, CancellationToken cancellationToken = default);

    public Task<Response<PagedResult<CommonTvSeries1>>> GetWatchlistTvAsync(int accountId, int page = 1, string language = "en-US", string sessionId = null, Sortby sortBy = Sortby.CreatedAtAsc, CancellationToken cancellationToken = default);
}
