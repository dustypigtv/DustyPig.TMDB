using DustyPig.REST;
using DustyPig.TMDB.Models.Credits;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Clients;

public class CreditsClient
{
    private readonly Client _client;

    internal CreditsClient(Client client) => _client = client;


    /// <summary>
    /// Get a movie or TV credit details by ID.
    /// </summary>
    public Task<Response<Details>> GetDetailsAsync(string creditId, CancellationToken cancellationToken = default) =>
        _client.GetAsync<Details>($"/3/credit/{creditId}", null, cancellationToken);
}
