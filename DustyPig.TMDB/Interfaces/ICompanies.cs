using DustyPig.REST;
using DustyPig.TMDB.Models.Common;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Interfaces;

public interface ICompanies
{
    /// <summary>
    /// Get the company details by ID.
    /// </summary>
    public Task<Response<ListResultWithId<AlternativeName>>> GetAlternativeNamesAsync(int companyId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the company details by ID.
    /// </summary>
    public Task<Response<Company>> GetDetailsAsync(int companyId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the company logos by id.
    /// </summary>
    public Task<Response<Logos_>> GetImagesAsync(int companyId, CancellationToken cancellationToken = default);
}
