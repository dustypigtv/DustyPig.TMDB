using DustyPig.TMDB.Interfaces;
using DustyPig.TMDB.Models.Common;
using DustyPig.TMDB.Models.Trending;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Clients;

internal class TrendingClient : ITrending
{
    private readonly Client _client;

    internal TrendingClient(Client client) => _client = client;


    /// <summary>
    /// Get the trending movies, TV shows and people.
    /// </summary>
    /// <param name="language">`ISO-639-1`-`ISO-3166-1` code</param>
    public Task<Response<PagedResult<CommonMedia>>> GetAllAsync(Timewindow timeWindow = Timewindow.Day, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "language", language }
        };

        return _client.GetAsync<PagedResult<CommonMedia>>($"/3/trending/all/{timeWindow.GetEnumDescription()}", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get the trending movies on TMDB.
    /// </summary>
    /// <param name="language">`ISO-639-1`-`ISO-3166-1` code</param>
    public Task<Response<PagedResult<CommonMedia>>> GetMoviesAsync(Timewindow timeWindow = Timewindow.Day, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "language", language }
        };

        return _client.GetAsync<PagedResult<CommonMedia>>($"/3/trending/movie/{timeWindow.GetEnumDescription()}", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get the trending people on TMDB.
    /// </summary>
    /// <param name="language">`ISO-639-1`-`ISO-3166-1` code</param>
    public Task<Response<PagedResult<Person>>> GetPeopleAsync(Timewindow timeWindow = Timewindow.Day, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "language", language }
        };

        return _client.GetAsync<PagedResult<Person>>($"/3/trending/person/{timeWindow.GetEnumDescription()}", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get the trending TV shows on TMDB.
    /// </summary>
    /// <param name="language">`ISO-639-1`-`ISO-3166-1` code</param>
    public Task<Response<PagedResult<CommonTvSeries3>>> GetTvSeriesAsync(Timewindow timeWindow = Timewindow.Day, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "language", language }
        };

        return _client.GetAsync<PagedResult<CommonTvSeries3>>($"/3/trending/tv/{timeWindow.GetEnumDescription()}", queryParams, cancellationToken);
    }
}
