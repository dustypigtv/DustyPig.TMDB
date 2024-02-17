using DustyPig.REST;
using DustyPig.TMDB.Interfaces;
using DustyPig.TMDB.Models.Account;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Clients;

internal class AccountClient : IAccount
{
	private readonly Client _client;

	internal AccountClient(Client client) => _client = client;


	public Task<Response<AddFavoriteResponse>> AddFavoriteAsync(AddFavoriteRequest postData, int accountId, string sessionId = null, CancellationToken cancellationToken = default)
	{
		var queryParams = new Dictionary<string, object>
		{
			{ "session_id", sessionId }
		};

		return _client.PostAsync<AddFavoriteResponse>($"/3/account/{accountId}/favorite", queryParams, postData, cancellationToken);
	}

	public Task<Response<AddToWatchlistResponse>> AddToWatchlistAsync(AddToWatchlistRequest postData, int accountId, string sessionId = null, CancellationToken cancellationToken = default)
	{
		var queryParams = new Dictionary<string, object>
		{
			{ "session_id", sessionId }
		};

		return _client.PostAsync<AddToWatchlistResponse>($"/3/account/{accountId}/watchlist", queryParams, postData, cancellationToken);
	}

	public Task<Response<DetailsResponse>> GetDetailsAsync(int accountId, string sessionId = null, CancellationToken cancellationToken = default)
	{
		var queryParams = new Dictionary<string, object>
		{
			{ "session_id", sessionId }
		};

		return _client.GetAsync<DetailsResponse>($"/3/account/{accountId}", queryParams, cancellationToken);
	}

	public Task<Response<FavoriteMoviesResponse>> GetFavoriteMoviesAsync(int accountId, int page = 1, string language = "en-US", string sessionId = null, Sortby sortBy = Sortby.CreatedAtAsc, CancellationToken cancellationToken = default)
	{
		var queryParams = new Dictionary<string, object>
		{
			{ "page", page },
			{ "language", language },
			{ "session_id", sessionId },
			{ "sort_by", sortBy.GetEnumDescription() }
		};

		return _client.GetAsync<FavoriteMoviesResponse>($"/3/account/{accountId}/favorite/movies", queryParams, cancellationToken);
	}

	public Task<Response<FavoriteTvResponse>> GetFavoriteTvAsync(int accountId, int page = 1, string language = "en-US", string sessionId = null, Sortby sortBy = Sortby.CreatedAtAsc, CancellationToken cancellationToken = default)
	{
		var queryParams = new Dictionary<string, object>
		{
			{ "page", page },
			{ "language", language },
			{ "session_id", sessionId },
			{ "sort_by", sortBy.GetEnumDescription() }
		};

		return _client.GetAsync<FavoriteTvResponse>($"/3/account/{accountId}/favorite/tv", queryParams, cancellationToken);
	}

	public Task<Response<ListsResponse>> GetListsAsync(int accountId, int page = 1, string sessionId = null, CancellationToken cancellationToken = default)
	{
		var queryParams = new Dictionary<string, object>
		{
			{ "page", page },
			{ "session_id", sessionId }
		};

		return _client.GetAsync<ListsResponse>($"/3/account/{accountId}/lists", queryParams, cancellationToken);
	}

	public Task<Response<RatedMoviesResponse>> GetRatedMoviesAsync(int accountId, int page = 1, string language = "en-US", string sessionId = null, Sortby sortBy = Sortby.CreatedAtAsc, CancellationToken cancellationToken = default)
	{
		var queryParams = new Dictionary<string, object>
		{
			{ "page", page },
			{ "language", language },
			{ "session_id", sessionId },
			{ "sort_by", sortBy.GetEnumDescription() }
		};

		return _client.GetAsync<RatedMoviesResponse>($"/3/account/{accountId}/rated/movies", queryParams, cancellationToken);
	}

	public Task<Response<RatedTvResponse>> GetRatedTvAsync(int accountId, int page = 1, string language = "en-US", string sessionId = null, Sortby sortBy = Sortby.CreatedAtAsc, CancellationToken cancellationToken = default)
	{
		var queryParams = new Dictionary<string, object>
		{
			{ "page", page },
			{ "language", language },
			{ "session_id", sessionId },
			{ "sort_by", sortBy.GetEnumDescription() }
		};

		return _client.GetAsync<RatedTvResponse>($"/3/account/{accountId}/rated/tv", queryParams, cancellationToken);
	}

	public Task<Response<RatedTvEpisodesResponse>> GetRatedTvEpisodesAsync(int accountId, int page = 1, string language = "en-US", string sessionId = null, Sortby sortBy = Sortby.CreatedAtAsc, CancellationToken cancellationToken = default)
	{
		var queryParams = new Dictionary<string, object>
		{
			{ "page", page },
			{ "language", language },
			{ "session_id", sessionId },
			{ "sort_by", sortBy.GetEnumDescription() }
		};

		return _client.GetAsync<RatedTvEpisodesResponse>($"/3/account/{accountId}/rated/tv/episodes", queryParams, cancellationToken);
	}

	public Task<Response<WatchlistMoviesResponse>> GetWatchlistMoviesAsync(int accountId, int page = 1, string language = "en-US", string sessionId = null, Sortby sortBy = Sortby.CreatedAtAsc, CancellationToken cancellationToken = default)
	{
		var queryParams = new Dictionary<string, object>
		{
			{ "page", page },
			{ "language", language },
			{ "session_id", sessionId },
			{ "sort_by", sortBy.GetEnumDescription() }
		};

		return _client.GetAsync<WatchlistMoviesResponse>($"/3/account/{accountId}/watchlist/movies", queryParams, cancellationToken);
	}

	public Task<Response<WatchlistTvResponse>> GetWatchlistTvAsync(int accountId, int page = 1, string language = "en-US", string sessionId = null, Sortby sortBy = Sortby.CreatedAtAsc, CancellationToken cancellationToken = default)
	{
		var queryParams = new Dictionary<string, object>
		{
			{ "page", page },
			{ "language", language },
			{ "session_id", sessionId },
			{ "sort_by", sortBy.GetEnumDescription() }
		};

		return _client.GetAsync<WatchlistTvResponse>($"/3/account/{accountId}/watchlist/tv", queryParams, cancellationToken);
	}
}
