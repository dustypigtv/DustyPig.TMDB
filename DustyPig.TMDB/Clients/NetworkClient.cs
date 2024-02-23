using DustyPig.REST;
using DustyPig.TMDB.Interfaces;
using DustyPig.TMDB.Models;
using DustyPig.TMDB.Models.Network;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Clients;

internal class NetworkClient : INetwork
{
    private readonly Client _client;

    internal NetworkClient(Client client) => _client = client;


    /// <summary>
    /// Get the alternative names of a network.
    /// </summary>
    public Task<Response<ListResultWithId<AlternativeNamesResponse>>> GetAlternativeNamesAsync(int networkId, CancellationToken cancellationToken = default) =>
        _client.GetAsync<ListResultWithId<AlternativeNamesResponse>>($"/3/network/{networkId}/alternative_names", null, cancellationToken);

    public Task<Response<DetailsResponse>> GetDetailsAsync(int networkId, CancellationToken cancellationToken = default) =>
        _client.GetAsync<DetailsResponse>($"/3/network/{networkId}", null, cancellationToken);

    /// <summary>
    /// Get the TV network logos by id.
    /// </summary>
    public Task<Response<ImagesResponse>> GetImagesAsync(int networkId, CancellationToken cancellationToken = default) =>
        _client.GetAsync<ImagesResponse>($"/3/network/{networkId}/images", null, cancellationToken);
}
