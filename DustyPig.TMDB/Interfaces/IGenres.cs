using DustyPig.REST;
using DustyPig.TMDB.Models.Genres;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Interfaces;

public interface IGenres
{
    /// <summary>
    /// Get the list of official genres for movies.
    /// </summary>
    public Task<Response<GenreList>> GetMovieListAsync(string language = "en-US", CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the list of official genres for TV shows.
    /// </summary>
    public Task<Response<GenreList>> GetTvListAsync(string language = "en-US", CancellationToken cancellationToken = default);
}
