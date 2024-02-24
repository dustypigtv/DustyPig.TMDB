using DustyPig.TMDB.Models.Common;
using DustyPig.TMDB.Models.Companies;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Interfaces;

public interface ICompanies
{
    /// <summary>
    /// Get the company details by ID.
    /// </summary>
    public Task<Response<ListResultWithId<CommonAlternativeName>>> GetAlternativeNamesAsync(int companyId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the company details by ID.
    /// </summary>
    public Task<Response<Details>> GetDetailsAsync(int companyId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the company logos by id.
    /// </summary>
    public Task<Response<CommonImages1>> GetImagesAsync(int companyId, CancellationToken cancellationToken = default);
}
