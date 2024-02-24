using DustyPig.TMDB.Interfaces;
using DustyPig.TMDB.Models.Common;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Clients;

public class TvSeriesListsClient : ITvSeriesLists
{
    private readonly Client _client;

    internal TvSeriesListsClient(Client client) => _client = client;


    /// <summary>
    /// Get a list of TV shows airing today.
    /// </summary>
    public Task<Response<PagedResult<CommonTvSeries2>>> GetAiringTodayAsync(int page = 1, string language = "en-US", string timezone = null, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "language", language },
            { "timezone", timezone }
        };

        return _client.GetAsync<PagedResult<CommonTvSeries2>>("/3/tv/airing_today", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get a list of TV shows that air in the next 7 days.
    /// </summary>
    public Task<Response<PagedResult<CommonTvSeries2>>> GetOnTheAirAsync(int page = 1, string language = "en-US", string timezone = null, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "language", language },
            { "timezone", timezone }
        };

        return _client.GetAsync<PagedResult<CommonTvSeries2>>("/3/tv/on_the_air", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get a list of TV shows ordered by popularity.
    /// </summary>
    public Task<Response<PagedResult<CommonTvSeries2>>> GetPopularAsync(int page = 1, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "language", language }
        };

        return _client.GetAsync<PagedResult<CommonTvSeries2>>("/3/tv/popular", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get a list of TV shows ordered by rating.
    /// </summary>
    public Task<Response<PagedResult<CommonTvSeries2>>> GetTopRatedAsync(int page = 1, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "language", language }
        };

        return _client.GetAsync<PagedResult<CommonTvSeries2>>("/3/tv/top_rated", queryParams, cancellationToken);
    }


}