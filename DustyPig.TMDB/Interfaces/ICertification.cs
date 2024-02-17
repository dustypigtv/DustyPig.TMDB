using DustyPig.REST;
using DustyPig.TMDB.Models.Certification;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Interfaces;

public interface ICertification
{
    /// <summary>
    /// Get an up to date list of the officially supported movie certifications on TMDB.
    /// </summary>
    public Task<Response<CertificationResponse>> GetMovieCertificationsAsync(CancellationToken cancellationToken = default);

    public Task<Response<CertificationResponse>> GetTvCertificationsAsync(CancellationToken cancellationToken = default);
}
