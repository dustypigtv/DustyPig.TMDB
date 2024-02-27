using DustyPig.REST;
using DustyPig.TMDB.Interfaces;
using DustyPig.TMDB.Models.Account;
using DustyPig.TMDB.Models.Common;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Clients;

internal class AccountClient : IAccount
{
    private readonly Client _client;

    internal AccountClient(Client client) => _client = client;


    public Task<Response<CommonStatus>> AddFavoriteAsync(AddFavorite postData, int accountId, string sessionId = null, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "session_id", sessionId }
        };

        return _client.PostAsync<CommonStatus>($"/3/account/{accountId}/favorite", queryParams, postData, cancellationToken);
    }

    public Task<Response<CommonStatus>> AddToWatchlistAsync(AddToWatchlist postData, int accountId, string sessionId = null, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "session_id", sessionId }
        };

        return _client.PostAsync<CommonStatus>($"/3/account/{accountId}/watchlist", queryParams, postData, cancellationToken);
    }

    public Task<Response<Details>> GetDetailsAsync(string sessionId = null, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "session_id", sessionId }
        };

        return _client.GetAsync<Details>($"/3/account", queryParams, cancellationToken);
    }

    public Task<Response<PagedResult<CommonMovie>>> GetFavoriteMoviesAsync(int accountId, int page = 1, string language = "en-US", string sessionId = null, CommonSortByCreated sortBy = CommonSortByCreated.CreatedAtAsc, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "language", language },
            { "session_id", sessionId },
            { "sort_by", sortBy.GetEnumDescription() }
        };

        return _client.GetAsync<PagedResult<CommonMovie>>($"/3/account/{accountId}/favorite/movies", queryParams, cancellationToken);
    }

    public Task<Response<PagedResult<CommonTvSeries1>>> GetFavoriteTvSeriesAsync(int accountId, int page = 1, string language = "en-US", string sessionId = null, CommonSortByCreated sortBy = CommonSortByCreated.CreatedAtAsc, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "language", language },
            { "session_id", sessionId },
            { "sort_by", sortBy.GetEnumDescription() }
        };

        return _client.GetAsync<PagedResult<CommonTvSeries1>>($"/3/account/{accountId}/favorite/tv", queryParams, cancellationToken);
    }

    public Task<Response<PagedResult<CommonList>>> GetListsAsync(int accountId, int page = 1, string sessionId = null, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "session_id", sessionId }
        };

        return _client.GetAsync<PagedResult<CommonList>>($"/3/account/{accountId}/lists", queryParams, cancellationToken);
    }

    public Task<Response<PagedResult<CommonRatedMovie>>> GetRatedMoviesAsync(int accountId, int page = 1, string language = "en-US", string sessionId = null, CommonSortByCreated sortBy = CommonSortByCreated.CreatedAtAsc, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "language", language },
            { "session_id", sessionId },
            { "sort_by", sortBy.GetEnumDescription() }
        };

        return _client.GetAsync<PagedResult<CommonRatedMovie>>($"/3/account/{accountId}/rated/movies", queryParams, cancellationToken);
    }

    public Task<Response<PagedResult<CommonRatedTvSeries>>> GetRatedTvSeriesAsync(int accountId, int page = 1, string language = "en-US", string sessionId = null, CommonSortByCreated sortBy = CommonSortByCreated.CreatedAtAsc, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "language", language },
            { "session_id", sessionId },
            { "sort_by", sortBy.GetEnumDescription() }
        };

        return _client.GetAsync<PagedResult<CommonRatedTvSeries>>($"/3/account/{accountId}/rated/tv", queryParams, cancellationToken);
    }

    public Task<Response<PagedResult<CommonRatedTvEpisode>>> GetRatedTvEpisodesAsync(int accountId, int page = 1, string language = "en-US", string sessionId = null, CommonSortByCreated sortBy = CommonSortByCreated.CreatedAtAsc, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "language", language },
            { "session_id", sessionId },
            { "sort_by", sortBy.GetEnumDescription() }
        };

        return _client.GetAsync<PagedResult<CommonRatedTvEpisode>>($"/3/account/{accountId}/rated/tv/episodes", queryParams, cancellationToken);
    }

    public Task<Response<PagedResult<CommonMovie>>> GetWatchlistMoviesAsync(int accountId, int page = 1, string language = "en-US", string sessionId = null, CommonSortByCreated sortBy = CommonSortByCreated.CreatedAtAsc, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "language", language },
            { "session_id", sessionId },
            { "sort_by", sortBy.GetEnumDescription() }
        };

        return _client.GetAsync<PagedResult<CommonMovie>>($"/3/account/{accountId}/watchlist/movies", queryParams, cancellationToken);
    }

    public Task<Response<PagedResult<CommonTvSeries1>>> GetWatchlistTvSeriesAsync(int accountId, int page = 1, string language = "en-US", string sessionId = null, CommonSortByCreated sortBy = CommonSortByCreated.CreatedAtAsc, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "language", language },
            { "session_id", sessionId },
            { "sort_by", sortBy.GetEnumDescription() }
        };

        return _client.GetAsync<PagedResult<CommonTvSeries1>>($"/3/account/{accountId}/watchlist/tv", queryParams, cancellationToken);
    }
}
