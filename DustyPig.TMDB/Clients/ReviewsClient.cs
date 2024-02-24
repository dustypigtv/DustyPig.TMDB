using DustyPig.TMDB.Interfaces;
using DustyPig.TMDB.Models.Reviews;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Clients;

internal class ReviewsClient : IReviews
{
    private readonly Client _client;

    internal ReviewsClient(Client client) => _client = client;


    /// <summary>
    /// Retrieve the details of a movie or TV show review.
    /// </summary>
    public Task<Response<Details>> GetDetailsAsync(string reviewId, CancellationToken cancellationToken = default) =>
        _client.GetAsync<Details>($"/3/review/{reviewId}", null, cancellationToken);
}
