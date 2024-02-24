using DustyPig.TMDB.Interfaces;
using DustyPig.TMDB.Models.Certifications;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Clients;

internal class CertificationsClient : ICertifications
{
    private readonly Client _client;

    internal CertificationsClient(Client client) => _client = client;


    /// <summary>
    /// Get an up to date list of the officially supported movie certifications on TMDB.
    /// </summary>
    public Task<Response<CertificationsList>> GetMovieCertificationsAsync(CancellationToken cancellationToken = default) =>
        _client.GetAsync<CertificationsList>("/3/certification/movie/list", null, cancellationToken);

    public Task<Response<CertificationsList>> GetTvCertificationsAsync(CancellationToken cancellationToken = default) =>
        _client.GetAsync<CertificationsList>("/3/certification/tv/list", null, cancellationToken);
}
