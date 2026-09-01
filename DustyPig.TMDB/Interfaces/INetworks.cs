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
    public Task<Response<ListResultWithId<CommonAlternativeName>>> GetAlternativeNamesAsync(int networkId, CancellationToken cancellationToken = default);

    public Task<Response<CommonCompany>> GetDetailsAsync(int networkId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the TV network logos by id.
    /// </summary>
    public Task<Response<CommonLogos>> GetImagesAsync(int networkId, CancellationToken cancellationToken = default);
}
