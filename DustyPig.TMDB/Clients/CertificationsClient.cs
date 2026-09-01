using DustyPig.REST;
using DustyPig.TMDB.Models.Certifications;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Clients;

public class CertificationsClient
{
    private readonly Client _client;

    internal CertificationsClient(Client client) => _client = client;


    /// <summary>
    /// Get an up to date list of the officially supported movie certifications on TMDB.
    /// </summary>
    public Task<Response<CertificationsList>> GetMovieCertificationsAsync(CancellationToken cancellationToken = default) =>
        _client.GetAsync<CertificationsList>("/3/certification/movie/list", null, cancellationToken);

    public Task<Response<CertificationsList>> GetTvSeriesCertificationsAsync(CancellationToken cancellationToken = default) =>
        _client.GetAsync<CertificationsList>("/3/certification/tv/list", null, cancellationToken);
}
