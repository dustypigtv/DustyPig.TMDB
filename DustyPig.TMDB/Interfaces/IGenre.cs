using DustyPig.REST;
using DustyPig.TMDB.Models.Genre;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Interfaces;

public interface IGenre
{
    /// <summary>
    /// Get the list of official genres for movies.
    /// </summary>
    public Task<Response<GenresResponse>> GetMovieListAsync(string language = "en-US", CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the list of official genres for TV shows.
    /// </summary>
    public Task<Response<GenresResponse>> GetTvListAsync(string language = "en-US", CancellationToken cancellationToken = default);
}
