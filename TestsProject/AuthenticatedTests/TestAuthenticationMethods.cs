using DustyPig.TMDB.Models.Authentication;
using DustyPig.TMDB.Models.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace TestsProject.AuthenticatedTests;

[TestClass]
public class TestAuthenticationMethods
{
    //Test this maually
    //[TestMethod]
    //[DoNotParallelize]
    public async Task CreateSession()
    {
        var client = ClientFactory.GetClient();


        //Step 1: Get a request token
        var createRequestTokenResponse = await client.Endpoints.Authentication.GetCreateRequestTokenAsync();

        //Step 2: Visit this link and approve the session
        var approveUrl = "https://www.themoviedb.org/authenticate/" + createRequestTokenResponse.Data.RequestToken;
        var breakpointHere = true;

        //Step 3: Create a sessionId
        CreateSessionRequest createSessionRequest = new() { RequestToken = createRequestTokenResponse.Data.RequestToken };
        var createSessionResponse = await client.Endpoints.Authentication.CreateSessionAsync(createSessionRequest);
        string sessionId = createSessionResponse.Data.SessionId;


        //Step 4: Delete the sessionId
        var deleteSessionRequest = new DeleteSessionRequest { SessionId = sessionId };
        await client.Endpoints.Authentication.DeleteSessionAsync(deleteSessionRequest);
    }






    [TestMethod]
    [DoNotParallelize]
    public async Task GuestSession()
    {
        await ClientFactory.GetClient().Endpoints.Authentication.GetCreateGuestSessionAsync();
    }



    //Test this maually
    //[TestMethod]
    //[DoNotParallelize]
    public async Task CreateSessionFromV4Token()
    {
        CreateSessionFromV4TokenRequest postData = new()
        {
            AccessToken = ""
        };

        await ClientFactory.GetClient().Endpoints.Authentication.CreateSessionFromV4TokenAsync(postData);
    }



    //Test this maually
    //[TestMethod]
    //[DoNotParallelize]
    public async Task CreateSessionWithLogin()
    {
        var client = ClientFactory.GetClient();


        //Step 1: Get a request token
        var createRequestTokenResponse = await client.Endpoints.Authentication.GetCreateRequestTokenAsync();


        //Step 2: Login
        CreateSessionWithLoginRequest postData = new()
        {
            Username = Environment.GetEnvironmentVariable("TMDB_API_USERNAME"),
            Password = Environment.GetEnvironmentVariable("TMDB_API_PASSWORD"),
            RequestToken = createRequestTokenResponse.Data.RequestToken
        };
        var createSessionFromLoginResponse = await client.Endpoints.Authentication.CreateSessionWithLoginAsync(postData);


        //Step 3: Create a sessionId
        CreateSessionRequest createSessionRequest = new() { RequestToken = createSessionFromLoginResponse.Data.RequestToken };
        var createSessionResponse = await client.Endpoints.Authentication.CreateSessionAsync(createSessionRequest);
        string sessionId = createSessionResponse.Data.SessionId;


        //Step 4: Delete the sessionId
        var deleteSessionRequest = new DeleteSessionRequest { SessionId = sessionId };
        await client.Endpoints.Authentication.DeleteSessionAsync(deleteSessionRequest);
    }






    [TestMethod]
    [DoNotParallelize]
    public async Task ValidateKey()
    {
        await ClientFactory.GetClient().Endpoints.Authentication.GetValidateKeyAsync();
    }
}
