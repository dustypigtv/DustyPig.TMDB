using DustyPig.REST;
using DustyPig.TMDB.Models.Credit;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Interfaces;

public interface ICredit
{
    /// <summary>
    /// Get a movie or TV credit details by ID.
    /// </summary>
    public Task<Response<Details>> GetDetailsAsync(string creditId, CancellationToken cancellationToken = default);
}
