using DustyPig.REST;
using DustyPig.TMDB.Interfaces;
using DustyPig.TMDB.Models.Common;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Clients;

internal class NetworksClient : INetworks
{
    private readonly Client _client;

    internal NetworksClient(Client client) => _client = client;


    /// <summary>
    /// Get the alternative names of a network.
    /// </summary>
    public Task<Response<ListResultWithId<AlternativeName>>> GetAlternativeNamesAsync(int networkId, CancellationToken cancellationToken = default) =>
        _client.GetAsync<ListResultWithId<AlternativeName>>($"/3/network/{networkId}/alternative_names", null, cancellationToken);

    public Task<Response<Company>> GetDetailsAsync(int networkId, CancellationToken cancellationToken = default) =>
        _client.GetAsync<Company>($"/3/network/{networkId}", null, cancellationToken);

    /// <summary>
    /// Get the TV network logos by id.
    /// </summary>
    public Task<Response<Logos_>> GetImagesAsync(int networkId, CancellationToken cancellationToken = default) =>
        _client.GetAsync<Logos_>($"/3/network/{networkId}/images", null, cancellationToken);
}
