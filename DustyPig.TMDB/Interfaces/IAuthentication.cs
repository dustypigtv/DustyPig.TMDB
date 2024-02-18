using DustyPig.REST;
using DustyPig.TMDB.Models.Authentication;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Interfaces;

public interface IAuthentication
{
    public Task<Response<CreateGuestSessionResponse>> GetCreateGuestSessionAsync(CancellationToken cancellationToken = default);

    public Task<Response<CreateRequestTokenResponse>> GetCreateRequestTokenAsync(CancellationToken cancellationToken = default);

    public Task<Response<CreateSessionResponse>> CreateSessionAsync(CreateSessionRequest postData, CancellationToken cancellationToken = default);

    public Task<Response<CreateSessionFromV4TokenResponse>> CreateSessionFromV4TokenAsync(CreateSessionFromV4TokenRequest postData, CancellationToken cancellationToken = default);

    /// <summary>
    /// This method allows an application to validate a request token by entering a username and password.
    /// </summary>
    public Task<Response<CreateSessionWithLoginResponse>> CreateSessionWithLoginAsync(CreateSessionWithLoginRequest postData, CancellationToken cancellationToken = default);

    public Task<Response<DeleteSessionResponse>> DeleteDeleteSessionAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Test your API Key to see if it&#39;s valid.
    /// </summary>
    public Task<Response<ValidateKeyResponse>> GetValidateKeyAsync(CancellationToken cancellationToken = default);
}
