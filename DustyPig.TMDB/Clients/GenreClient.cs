using DustyPig.REST;
using DustyPig.TMDB.Interfaces;
using DustyPig.TMDB.Models.Genre;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Clients;

internal class GenreClient : IGenre
{
    private readonly Client _client;

    internal GenreClient(Client client) => _client = client;


    /// <summary>
    /// Get the list of official genres for movies.
    /// </summary>
    public Task<Response<MovieListResponse>> GetMovieListAsync(string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "language", language }
        };

        return _client.GetAsync<MovieListResponse>("/3/genre/movie/list", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get the list of official genres for TV shows.
    /// </summary>
    public Task<Response<TvListResponse>> GetTvListAsync(string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "language", language }
        };

        return _client.GetAsync<TvListResponse>("/3/genre/tv/list", queryParams, cancellationToken);
    }
}
