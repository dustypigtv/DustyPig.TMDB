using DustyPig.REST;
using DustyPig.TMDB.Interfaces;
using DustyPig.TMDB.Models.Review;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Clients;

internal class ReviewClient : IReview
{
	private readonly Client _client;

	internal ReviewClient(Client client) => _client = client;


	/// <summary>
	/// Retrieve the details of a movie or TV show review.
	/// </summary>
	public Task<Response<DetailsResponse>> GetDetailsAsync(string reviewId, CancellationToken cancellationToken = default) =>
		_client.GetAsync<DetailsResponse>($"/3/review/{reviewId}", null, cancellationToken);
}
