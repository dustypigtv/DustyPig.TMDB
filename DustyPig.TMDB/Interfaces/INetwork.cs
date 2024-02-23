using DustyPig.REST;
using DustyPig.TMDB.Models;
using DustyPig.TMDB.Models.Network;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Interfaces;

public interface INetwork
{
    /// <summary>
    /// Get the alternative names of a network.
    /// </summary>
    public Task<Response<ListResultWithId<AlternativeNamesResponse>>> GetAlternativeNamesAsync(int networkId, CancellationToken cancellationToken = default);

    public Task<Response<DetailsResponse>> GetDetailsAsync(int networkId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the TV network logos by id.
    /// </summary>
    public Task<Response<ImagesResponse>> GetImagesAsync(int networkId, CancellationToken cancellationToken = default);
}
