using DustyPig.REST;
using DustyPig.TMDB.Models.Credits;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Interfaces;

public interface ICredits
{
    /// <summary>
    /// Get a movie or TV credit details by ID.
    /// </summary>
    public Task<Response<Details>> GetDetailsAsync(string creditId, CancellationToken cancellationToken = default);
}
