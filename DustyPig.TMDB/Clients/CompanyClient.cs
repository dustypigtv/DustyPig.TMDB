using DustyPig.REST;
using DustyPig.TMDB.Interfaces;
using DustyPig.TMDB.Models.Common;
using DustyPig.TMDB.Models.Company;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Clients;

internal class CompanyClient : ICompany
{
    private readonly Client _client;

    internal CompanyClient(Client client) => _client = client;


    /// <summary>
    /// Get the company details by ID.
    /// </summary>
    public Task<Response<ListResultWithId<CommonAlternativeName>>> GetAlternativeNamesAsync(int companyId, CancellationToken cancellationToken = default) =>
        _client.GetAsync<ListResultWithId<CommonAlternativeName>>($"/3/company/{companyId}/alternative_names", null, cancellationToken);

    /// <summary>
    /// Get the company details by ID.
    /// </summary>
    public Task<Response<DetailsResponse>> GetDetailsAsync(int companyId, CancellationToken cancellationToken = default) =>
        _client.GetAsync<DetailsResponse>($"/3/company/{companyId}", null, cancellationToken);

    /// <summary>
    /// Get the company logos by id.
    /// </summary>
    public Task<Response<CommonImages1>> GetImagesAsync(int companyId, CancellationToken cancellationToken = default) =>
        _client.GetAsync<CommonImages1>($"/3/company/{companyId}/images", null, cancellationToken);
}
