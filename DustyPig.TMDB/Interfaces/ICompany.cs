using DustyPig.REST;
using DustyPig.TMDB.Models.Common;
using DustyPig.TMDB.Models.Company;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Interfaces;

public interface ICompany
{
    /// <summary>
    /// Get the company details by ID.
    /// </summary>
    public Task<Response<ListResultWithId<CommonAlternativeName>>> GetAlternativeNamesAsync(int companyId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the company details by ID.
    /// </summary>
    public Task<Response<DetailsResponse>> GetDetailsAsync(int companyId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the company logos by id.
    /// </summary>
    public Task<Response<CommonImages1>> GetImagesAsync(int companyId, CancellationToken cancellationToken = default);
}
