using DustyPig.REST;
using DustyPig.TMDB.Interfaces;
using DustyPig.TMDB.Models;
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
    public Task<Response<PagedResult<AllResponse>>> GetAllAsync(Timewindow timeWindow = Timewindow.Day, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "language", language }
        };

        return _client.GetAsync<PagedResult<AllResponse>>($"/3/trending/all/{timeWindow}", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get the trending movies on TMDB.
    /// </summary>
    /// <param name="language">`ISO-639-1`-`ISO-3166-1` code</param>
    public Task<Response<PagedResult<MoviesResponse>>> GetMoviesAsync(Timewindow timeWindow = Timewindow.Day, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "language", language }
        };

        return _client.GetAsync<PagedResult<MoviesResponse>>($"/3/trending/movie/{timeWindow}", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get the trending people on TMDB.
    /// </summary>
    /// <param name="language">`ISO-639-1`-`ISO-3166-1` code</param>
    public Task<Response<PagedResult<PeopleResponse>>> GetPeopleAsync(Timewindow timeWindow = Timewindow.Day, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "language", language }
        };

        return _client.GetAsync<PagedResult<PeopleResponse>>($"/3/trending/person/{timeWindow}", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get the trending TV shows on TMDB.
    /// </summary>
    /// <param name="language">`ISO-639-1`-`ISO-3166-1` code</param>
    public Task<Response<PagedResult<TvResponse>>> GetTvAsync(Timewindow timeWindow = Timewindow.Day, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "language", language }
        };

        return _client.GetAsync<PagedResult<TvResponse>>($"/3/trending/tv/{timeWindow}", queryParams, cancellationToken);
    }
}
