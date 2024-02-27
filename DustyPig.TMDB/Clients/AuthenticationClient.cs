using DustyPig.REST;
using DustyPig.TMDB.Interfaces;
using DustyPig.TMDB.Models.Authentication;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Clients;

internal class AuthenticationClient : IAuthentication
{
    private readonly Client _client;

    internal AuthenticationClient(Client client) => _client = client;


    public Task<Response<GuestSession>> GetCreateGuestSessionAsync(CancellationToken cancellationToken = default) =>
        _client.GetAsync<GuestSession>("/3/authentication/guest_session/new", null, cancellationToken);

    public Task<Response<TokenResponse>> GetCreateRequestTokenAsync(CancellationToken cancellationToken = default) =>
        _client.GetAsync<TokenResponse>("/3/authentication/token/new", null, cancellationToken);

    public Task<Response<CreateSessionResponse>> CreateSessionAsync(CreateSessionRequest postData, CancellationToken cancellationToken = default) =>
        _client.PostAsync<CreateSessionResponse>("/3/authentication/session/new", null, postData, cancellationToken);

    public Task<Response<CreateSessionResponse>> CreateSessionFromV4TokenAsync(CreateSessionFromV4TokenRequest postData, CancellationToken cancellationToken = default) =>
        _client.PostAsync<CreateSessionResponse>("/3/authentication/session/convert/4", null, postData, cancellationToken);

    /// <summary>
    /// This method allows an application to validate a request token by entering a username and password.
    /// </summary>
    public Task<Response<TokenResponse>> CreateSessionWithLoginAsync(CreateSessionWithLoginRequest postData, CancellationToken cancellationToken = default) =>
        _client.PostAsync<TokenResponse>("/3/authentication/token/validate_with_login", null, postData, cancellationToken);

    public Task<Response<DeleteSessionResponse>> DeleteSessionAsync(DeleteSessionRequest deleteSessionRequest, CancellationToken cancellationToken = default) =>
        _client.DeleteAsync<DeleteSessionResponse>("/3/authentication/session", null, deleteSessionRequest, cancellationToken);

    /// <summary>
    /// Test your API Key to see if it&#39;s valid.
    /// </summary>
    public Task<Response<ValidateKey>> GetValidateKeyAsync(CancellationToken cancellationToken = default) =>
        _client.GetAsync<ValidateKey>("/3/authentication", null, cancellationToken);
}
