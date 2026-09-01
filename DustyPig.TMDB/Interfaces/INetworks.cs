using DustyPig.REST;
using DustyPig.TMDB.Models.Common;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Interfaces;

public interface INetworks
{
    /// <summary>
    /// Get the alternative names of a network.
    /// </summary>
    public Task<Response<ListResultWithId<AlternativeName>>> GetAlternativeNamesAsync(int networkId, CancellationToken cancellationToken = default);

    public Task<Response<Company>> GetDetailsAsync(int networkId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the TV network logos by id.
    /// </summary>
    public Task<Response<Logos_>> GetImagesAsync(int networkId, CancellationToken cancellationToken = default);
}
