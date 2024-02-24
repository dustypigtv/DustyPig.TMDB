using DustyPig.REST;
using DustyPig.TMDB.Interfaces;
using DustyPig.TMDB.Models.Common;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Clients;

internal class MovieListsClient : IMovieLists
{
    private readonly Client _client;

    internal MovieListsClient(Client client) => _client = client;

    /// <summary>
    /// Get a list of movies that are currently in theatres.
    /// </summary>
    /// <param name="region">ISO-3166-1 code</param>
    public Task<Response<PagedResultWithDateRange<CommonMovie>>> GetNowPlayingAsync(int page = 1, string language = "en-US", string region = null, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "language", language },
            { "region", region }
        };

        return _client.GetAsync<PagedResultWithDateRange<CommonMovie>>("/3/movie/now_playing", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get a list of movies ordered by popularity.
    /// </summary>
    /// <param name="region">ISO-3166-1 code</param>
    public Task<Response<PagedResult<CommonMovie>>> GetPopularAsync(int page = 1, string language = "en-US", string region = null, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "language", language },
            { "region", region }
        };

        return _client.GetAsync<PagedResult<CommonMovie>>("/3/movie/popular", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get a list of movies ordered by rating.
    /// </summary>
    /// <param name="region">ISO-3166-1 code</param>
    public Task<Response<PagedResult<CommonMovie>>> GetTopRatedAsync(int page = 1, string language = "en-US", string region = null, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "language", language },
            { "region", region }
        };

        return _client.GetAsync<PagedResult<CommonMovie>>("/3/movie/top_rated", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get a list of movies that are being released soon.
    /// </summary>
    /// <param name="region">ISO-3166-1 code</param>
    public Task<Response<PagedResultWithDateRange<CommonMovie>>> GetUpcomingAsync(int page = 1, string language = "en-US", string region = null, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "language", language },
            { "region", region }
        };

        return _client.GetAsync<PagedResultWithDateRange<CommonMovie>>("/3/movie/upcoming", queryParams, cancellationToken);
    }

}