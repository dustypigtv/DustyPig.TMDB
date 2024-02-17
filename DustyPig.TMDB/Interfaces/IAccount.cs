using DustyPig.REST;
using DustyPig.TMDB.Models.Account;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Interfaces;

public interface IAccount
{
	public Task<Response<AddFavoriteResponse>> AddFavoriteAsync(AddFavoriteRequest postData, int accountId, string sessionId = null, CancellationToken cancellationToken = default);

	public Task<Response<AddToWatchlistResponse>> AddToWatchlistAsync(AddToWatchlistRequest postData, int accountId, string sessionId = null, CancellationToken cancellationToken = default);

	public Task<Response<DetailsResponse>> GetDetailsAsync(int accountId, string sessionId = null, CancellationToken cancellationToken = default);

	public Task<Response<FavoriteMoviesResponse>> GetFavoriteMoviesAsync(int accountId, int page = 1, string language = "en-US", string sessionId = null, Sortby sortBy = Sortby.CreatedAtAsc, CancellationToken cancellationToken = default);

	public Task<Response<FavoriteTvResponse>> GetFavoriteTvAsync(int accountId, int page = 1, string language = "en-US", string sessionId = null, Sortby sortBy = Sortby.CreatedAtAsc, CancellationToken cancellationToken = default);

	public Task<Response<ListsResponse>> GetListsAsync(int accountId, int page = 1, string sessionId = null, CancellationToken cancellationToken = default);

	public Task<Response<RatedMoviesResponse>> GetRatedMoviesAsync(int accountId, int page = 1, string language = "en-US", string sessionId = null, Sortby sortBy = Sortby.CreatedAtAsc, CancellationToken cancellationToken = default);

	public Task<Response<RatedTvResponse>> GetRatedTvAsync(int accountId, int page = 1, string language = "en-US", string sessionId = null, Sortby sortBy = Sortby.CreatedAtAsc, CancellationToken cancellationToken = default);

	public Task<Response<RatedTvEpisodesResponse>> GetRatedTvEpisodesAsync(int accountId, int page = 1, string language = "en-US", string sessionId = null, Sortby sortBy = Sortby.CreatedAtAsc, CancellationToken cancellationToken = default);

	public Task<Response<WatchlistMoviesResponse>> GetWatchlistMoviesAsync(int accountId, int page = 1, string language = "en-US", string sessionId = null, Sortby sortBy = Sortby.CreatedAtAsc, CancellationToken cancellationToken = default);

	public Task<Response<WatchlistTvResponse>> GetWatchlistTvAsync(int accountId, int page = 1, string language = "en-US", string sessionId = null, Sortby sortBy = Sortby.CreatedAtAsc, CancellationToken cancellationToken = default);
}
