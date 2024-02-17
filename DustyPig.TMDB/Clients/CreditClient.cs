using DustyPig.REST;
using DustyPig.TMDB.Interfaces;
using DustyPig.TMDB.Models.Credit;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Clients;

internal class CreditClient : ICredit
{
	private readonly Client _client;

	internal CreditClient(Client client) => _client = client;


	/// <summary>
	/// Get a movie or TV credit details by ID.
	/// </summary>
	public Task<Response<DetailsResponse>> GetDetailsAsync(string creditId, CancellationToken cancellationToken = default) =>
		_client.GetAsync<DetailsResponse>($"/3/credit/{creditId}", null, cancellationToken);
}
