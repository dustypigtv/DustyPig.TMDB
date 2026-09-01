using DustyPig.REST;
using DustyPig.TMDB.Models.Common;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Clients;

public class CompaniesClient
{
    private readonly Client _client;

    internal CompaniesClient(Client client) => _client = client;


    /// <summary>
    /// Get the company details by ID.
    /// </summary>
    public Task<Response<ListResultWithId<AlternativeName>>> GetAlternativeNamesAsync(int companyId, CancellationToken cancellationToken = default) =>
        _client.GetAsync<ListResultWithId<AlternativeName>>($"/3/company/{companyId}/alternative_names", null, cancellationToken);

    /// <summary>
    /// Get the company details by ID.
    /// </summary>
    public Task<Response<Company>> GetDetailsAsync(int companyId, CancellationToken cancellationToken = default) =>
        _client.GetAsync<Company>($"/3/company/{companyId}", null, cancellationToken);

    /// <summary>
    /// Get the company logos by id.
    /// </summary>
    public Task<Response<Logos_>> GetImagesAsync(int companyId, CancellationToken cancellationToken = default) =>
        _client.GetAsync<Logos_>($"/3/company/{companyId}/images", null, cancellationToken);
}
