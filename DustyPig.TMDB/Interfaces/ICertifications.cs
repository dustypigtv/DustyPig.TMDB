using DustyPig.TMDB.Models.Certifications;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Interfaces;

public interface ICertifications
{
    /// <summary>
    /// Get an up to date list of the officially supported movie certifications on TMDB.
    /// </summary>
    public Task<Response<CertificationsList>> GetMovieCertificationsAsync(CancellationToken cancellationToken = default);

    public Task<Response<CertificationsList>> GetTvSeriesCertificationsAsync(CancellationToken cancellationToken = default);
}
