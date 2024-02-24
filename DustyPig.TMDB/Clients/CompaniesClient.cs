using DustyPig.TMDB.Interfaces;
using DustyPig.TMDB.Models.Common;
using DustyPig.TMDB.Models.Companies;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Clients;

internal class CompaniesClient : ICompanies
{
    private readonly Client _client;

    internal CompaniesClient(Client client) => _client = client;


    /// <summary>
    /// Get the company details by ID.
    /// </summary>
    public Task<Response<ListResultWithId<CommonAlternativeName>>> GetAlternativeNamesAsync(int companyId, CancellationToken cancellationToken = default) =>
        _client.GetAsync<ListResultWithId<CommonAlternativeName>>($"/3/company/{companyId}/alternative_names", null, cancellationToken);

    /// <summary>
    /// Get the company details by ID.
    /// </summary>
    public Task<Response<Details>> GetDetailsAsync(int companyId, CancellationToken cancellationToken = default) =>
        _client.GetAsync<Details>($"/3/company/{companyId}", null, cancellationToken);

    /// <summary>
    /// Get the company logos by id.
    /// </summary>
    public Task<Response<CommonImages1>> GetImagesAsync(int companyId, CancellationToken cancellationToken = default) =>
        _client.GetAsync<CommonImages1>($"/3/company/{companyId}/images", null, cancellationToken);
}
