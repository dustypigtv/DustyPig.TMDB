using DustyPig.TMDB.Interfaces;
using DustyPig.TMDB.Models.Common;
using DustyPig.TMDB.Models.Networks;
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
    public Task<Response<ListResultWithId<CommonAlternativeName>>> GetAlternativeNamesAsync(int networkId, CancellationToken cancellationToken = default) =>
        _client.GetAsync<ListResultWithId<CommonAlternativeName>>($"/3/network/{networkId}/alternative_names", null, cancellationToken);

    public Task<Response<Details>> GetDetailsAsync(int networkId, CancellationToken cancellationToken = default) =>
        _client.GetAsync<Details>($"/3/network/{networkId}", null, cancellationToken);

    /// <summary>
    /// Get the TV network logos by id.
    /// </summary>
    public Task<Response<CommonImages1>> GetImagesAsync(int networkId, CancellationToken cancellationToken = default) =>
        _client.GetAsync<CommonImages1>($"/3/network/{networkId}/images", null, cancellationToken);
}
