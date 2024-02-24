using DustyPig.TMDB.Models.Reviews;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Interfaces;

public interface IReviews
{
    /// <summary>
    /// Retrieve the details of a movie or TV show review.
    /// </summary>
    public Task<Response<Details>> GetDetailsAsync(string reviewId, CancellationToken cancellationToken = default);
}
