using DustyPig.REST;
using DustyPig.TMDB.Interfaces;
using DustyPig.TMDB.Models.Genres;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Clients;

internal class GenresClient : IGenres
{
    private readonly Client _client;

    internal GenresClient(Client client) => _client = client;


    /// <summary>
    /// Get the list of official genres for movies.
    /// </summary>
    public Task<Response<GenreList>> GetMovieListAsync(string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "language", language }
        };

        return _client.GetAsync<GenreList>("/3/genre/movie/list", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get the list of official genres for TV shows.
    /// </summary>
    public Task<Response<GenreList>> GetTvListAsync(string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "language", language }
        };

        return _client.GetAsync<GenreList>("/3/genre/tv/list", queryParams, cancellationToken);
    }
}
