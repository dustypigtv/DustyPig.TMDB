using DustyPig.REST;
using DustyPig.TMDB.Models.Authentication;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Interfaces;

public interface IAuthentication
{
    public Task<Response<GuestSession>> GetCreateGuestSessionAsync(CancellationToken cancellationToken = default);

    public Task<Response<TokenResponse>> GetCreateRequestTokenAsync(CancellationToken cancellationToken = default);

    public Task<Response<CreateSessionResponse>> CreateSessionAsync(CreateSessionRequest postData, CancellationToken cancellationToken = default);

    public Task<Response<CreateSessionResponse>> CreateSessionFromV4TokenAsync(CreateSessionFromV4TokenRequest postData, CancellationToken cancellationToken = default);

    /// <summary>
    /// This method allows an application to validate a request token by entering a username and password.
    /// </summary>
    public Task<Response<TokenResponse>> CreateSessionWithLoginAsync(CreateSessionWithLoginRequest postData, CancellationToken cancellationToken = default);

    public Task<Response<DeleteSessionResponse>> DeleteSessionAsync(DeleteSessionRequest deleteSessionRequest, CancellationToken cancellationToken = default);

    /// <summary>
    /// Test your API Key to see if it&#39;s valid.
    /// </summary>
    public Task<Response> ValidateKeyAsync(CancellationToken cancellationToken = default);
}
