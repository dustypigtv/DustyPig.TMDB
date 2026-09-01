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

    //public Task<Response<PagedResult<CommonMedia>>> GetFavoriteMoviesAsync(int accountId, int page = 1, string language = "en-US", string sessionId = null, CommonSortByCreated sortBy = CommonSortByCreated.CreatedAtAsc, CancellationToken cancellationToken = default)
    //{
    //    var queryParams = new Dictionary<string, object>
    //    {
    //        { "page", page },
    //        { "language", language },
    //        { "session_id", sessionId },
    //        { "sort_by", sortBy.GetEnumDescription() }
    //    };

    //    return _client.GetAsync<PagedResult<CommonMedia>>($"/3/account/{accountId}/favorite/movies", queryParams, cancellationToken);
    //}

    public Task<Response<PagedResult<Movie>>> GetFavoriteMoviesAsync(int accountId, int page = 1, string language = "en-US", string sessionId = null, CommonSortByCreated sortBy = CommonSortByCreated.CreatedAtAsc, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "language", language },
            { "session_id", sessionId },
            { "sort_by", sortBy.GetEnumDescription() }
        };

        return _client.GetAsync<PagedResult<Movie>>($"/3/account/{accountId}/favorite/movies", queryParams, cancellationToken);

    }

    //public Task<Response<PagedResult<CommonMedia>>> GetFavoriteTvSeriesAsync(int accountId, int page = 1, string language = "en-US", string sessionId = null, CommonSortByCreated sortBy = CommonSortByCreated.CreatedAtAsc, CancellationToken cancellationToken = default)
    //{
    //    var queryParams = new Dictionary<string, object>
    //    {
    //        { "page", page },
    //        { "language", language },
    //        { "session_id", sessionId },
    //        { "sort_by", sortBy.GetEnumDescription() }
    //    };

    //    return _client.GetAsync<PagedResult<CommonMedia>>($"/3/account/{accountId}/favorite/tv", queryParams, cancellationToken);
    //}

    public Task<Response<PagedResult<Series>>> GetFavoriteTvSeriesAsync(int accountId, int page = 1, string language = "en-US", string sessionId = null, CommonSortByCreated sortBy = CommonSortByCreated.CreatedAtAsc, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "language", language },
            { "session_id", sessionId },
            { "sort_by", sortBy.GetEnumDescription() }
        };

        return _client.GetAsync<PagedResult<Series>>($"/3/account/{accountId}/favorite/tv", queryParams, cancellationToken);
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

    //public Task<Response<PagedResult<CommonMedia>>> GetRatedMoviesAsync(int accountId, int page = 1, string language = "en-US", string sessionId = null, CommonSortByCreated sortBy = CommonSortByCreated.CreatedAtAsc, CancellationToken cancellationToken = default)
    //{
    //    var queryParams = new Dictionary<string, object>
    //    {
    //        { "page", page },
    //        { "language", language },
    //        { "session_id", sessionId },
    //        { "sort_by", sortBy.GetEnumDescription() }
    //    };

    //    return _client.GetAsync<PagedResult<CommonMedia>>($"/3/account/{accountId}/rated/movies", queryParams, cancellationToken);
    //}

    public Task<Response<PagedResult<Movie>>> GetRatedMoviesAsync(int accountId, int page = 1, string language = "en-US", string sessionId = null, CommonSortByCreated sortBy = CommonSortByCreated.CreatedAtAsc, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "language", language },
            { "session_id", sessionId },
            { "sort_by", sortBy.GetEnumDescription() }
        };

        return _client.GetAsync<PagedResult<Movie>>($"/3/account/{accountId}/rated/movies", queryParams, cancellationToken);
    }

    //public Task<Response<PagedResult<CommonMedia>>> GetRatedTvSeriesAsync(int accountId, int page = 1, string language = "en-US", string sessionId = null, CommonSortByCreated sortBy = CommonSortByCreated.CreatedAtAsc, CancellationToken cancellationToken = default)
    //{
    //    var queryParams = new Dictionary<string, object>
    //    {
    //        { "page", page },
    //        { "language", language },
    //        { "session_id", sessionId },
    //        { "sort_by", sortBy.GetEnumDescription() }
    //    };

    //    return _client.GetAsync<PagedResult<CommonMedia>>($"/3/account/{accountId}/rated/tv", queryParams, cancellationToken);
    //}

    public Task<Response<PagedResult<Series>>> GetRatedTvSeriesAsync(int accountId, int page = 1, string language = "en-US", string sessionId = null, CommonSortByCreated sortBy = CommonSortByCreated.CreatedAtAsc, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "language", language },
            { "session_id", sessionId },
            { "sort_by", sortBy.GetEnumDescription() }
        };

        return _client.GetAsync<PagedResult<Series>>($"/3/account/{accountId}/rated/tv", queryParams, cancellationToken);
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

    //public Task<Response<PagedResult<CommonMedia>>> GetWatchlistMoviesAsync(int accountId, int page = 1, string language = "en-US", string sessionId = null, CommonSortByCreated sortBy = CommonSortByCreated.CreatedAtAsc, CancellationToken cancellationToken = default)
    //{
    //    var queryParams = new Dictionary<string, object>
    //    {
    //        { "page", page },
    //        { "language", language },
    //        { "session_id", sessionId },
    //        { "sort_by", sortBy.GetEnumDescription() }
    //    };

    //    return _client.GetAsync<PagedResult<CommonMedia>>($"/3/account/{accountId}/watchlist/movies", queryParams, cancellationToken);
    //}

    public Task<Response<PagedResult<Movie>>> GetWatchlistMoviesAsync(int accountId, int page = 1, string language = "en-US", string sessionId = null, CommonSortByCreated sortBy = CommonSortByCreated.CreatedAtAsc, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "language", language },
            { "session_id", sessionId },
            { "sort_by", sortBy.GetEnumDescription() }
        };

        return _client.GetAsync<PagedResult<Movie>>($"/3/account/{accountId}/watchlist/movies", queryParams, cancellationToken);
    }

    //public Task<Response<PagedResult<CommonMedia>>> GetWatchlistTvSeriesAsync(int accountId, int page = 1, string language = "en-US", string sessionId = null, CommonSortByCreated sortBy = CommonSortByCreated.CreatedAtAsc, CancellationToken cancellationToken = default)
    //{
    //    var queryParams = new Dictionary<string, object>
    //    {
    //        { "page", page },
    //        { "language", language },
    //        { "session_id", sessionId },
    //        { "sort_by", sortBy.GetEnumDescription() }
    //    };

    //    return _client.GetAsync<PagedResult<CommonMedia>>($"/3/account/{accountId}/watchlist/tv", queryParams, cancellationToken);
    //}

    public Task<Response<PagedResult<Series>>> GetWatchlistTvSeriesAsync(int accountId, int page = 1, string language = "en-US", string sessionId = null, CommonSortByCreated sortBy = CommonSortByCreated.CreatedAtAsc, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "language", language },
            { "session_id", sessionId },
            { "sort_by", sortBy.GetEnumDescription() }
        };

        return _client.GetAsync<PagedResult<Series>>($"/3/account/{accountId}/watchlist/tv", queryParams, cancellationToken);
    }


}
