using DustyPig.REST;
using DustyPig.TMDB.Interfaces;
using DustyPig.TMDB.Models;
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

    public Task<Response<AccountDetails>> GetDetailsAsync(int accountId, string sessionId = null, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "session_id", sessionId }
        };

        return _client.GetAsync<AccountDetails>($"/3/account/{accountId}", queryParams, cancellationToken);
    }

    public Task<Response<PagedResult<FavoriteMoviesResponse>>> GetFavoriteMoviesAsync(int accountId, int page = 1, string language = "en-US", string sessionId = null, Sortby sortBy = Sortby.CreatedAtAsc, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "language", language },
            { "session_id", sessionId },
            { "sort_by", sortBy.GetEnumDescription() }
        };

        return _client.GetAsync<PagedResult<FavoriteMoviesResponse>>($"/3/account/{accountId}/favorite/movies", queryParams, cancellationToken);
    }

    public Task<Response<PagedResult<FavoriteTvResponse>>> GetFavoriteTvAsync(int accountId, int page = 1, string language = "en-US", string sessionId = null, Sortby sortBy = Sortby.CreatedAtAsc, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "language", language },
            { "session_id", sessionId },
            { "sort_by", sortBy.GetEnumDescription() }
        };

        return _client.GetAsync<PagedResult<FavoriteTvResponse>>($"/3/account/{accountId}/favorite/tv", queryParams, cancellationToken);
    }

    public Task<Response<PagedResult<ListsResponse>>> GetListsAsync(int accountId, int page = 1, string sessionId = null, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "session_id", sessionId }
        };

        return _client.GetAsync<PagedResult<ListsResponse>>($"/3/account/{accountId}/lists", queryParams, cancellationToken);
    }

    public Task<Response<PagedResult<RatedMoviesResponse>>> GetRatedMoviesAsync(int accountId, int page = 1, string language = "en-US", string sessionId = null, Sortby sortBy = Sortby.CreatedAtAsc, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "language", language },
            { "session_id", sessionId },
            { "sort_by", sortBy.GetEnumDescription() }
        };

        return _client.GetAsync<PagedResult<RatedMoviesResponse>>($"/3/account/{accountId}/rated/movies", queryParams, cancellationToken);
    }

    public Task<Response<PagedResult<RatedTvResponse>>> GetRatedTvAsync(int accountId, int page = 1, string language = "en-US", string sessionId = null, Sortby sortBy = Sortby.CreatedAtAsc, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "language", language },
            { "session_id", sessionId },
            { "sort_by", sortBy.GetEnumDescription() }
        };

        return _client.GetAsync<PagedResult<RatedTvResponse>>($"/3/account/{accountId}/rated/tv", queryParams, cancellationToken);
    }

    public Task<Response<PagedResult<RatedTvEpisodesResponse>>> GetRatedTvEpisodesAsync(int accountId, int page = 1, string language = "en-US", string sessionId = null, Sortby sortBy = Sortby.CreatedAtAsc, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "language", language },
            { "session_id", sessionId },
            { "sort_by", sortBy.GetEnumDescription() }
        };

        return _client.GetAsync<PagedResult<RatedTvEpisodesResponse>>($"/3/account/{accountId}/rated/tv/episodes", queryParams, cancellationToken);
    }

    public Task<Response<PagedResult<WatchlistMoviesResponse>>> GetWatchlistMoviesAsync(int accountId, int page = 1, string language = "en-US", string sessionId = null, Sortby sortBy = Sortby.CreatedAtAsc, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "language", language },
            { "session_id", sessionId },
            { "sort_by", sortBy.GetEnumDescription() }
        };

        return _client.GetAsync<PagedResult<WatchlistMoviesResponse>>($"/3/account/{accountId}/watchlist/movies", queryParams, cancellationToken);
    }

    public Task<Response<PagedResult<WatchlistTvResponse>>> GetWatchlistTvAsync(int accountId, int page = 1, string language = "en-US", string sessionId = null, Sortby sortBy = Sortby.CreatedAtAsc, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "language", language },
            { "session_id", sessionId },
            { "sort_by", sortBy.GetEnumDescription() }
        };

        return _client.GetAsync<PagedResult<WatchlistTvResponse>>($"/3/account/{accountId}/watchlist/tv", queryParams, cancellationToken);
    }
}
