using DustyPig.REST;
using DustyPig.TMDB.Models.Review;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Interfaces;

public interface IReview
{
	/// <summary>
	/// Retrieve the details of a movie or TV show review.
	/// </summary>
	public Task<Response<DetailsResponse>> GetDetailsAsync(string reviewId, CancellationToken cancellationToken = default);
}
