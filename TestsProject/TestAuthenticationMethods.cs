using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsProject;

//[TestClass]
public class TestAuthenticationMethods
{
    [TestMethod]
    [DoNotParallelize]
    public async Task GetCreateGuestSessionAsync()
    {
        await ClientFactory.GetClient().Endpoints.Authentication.GetCreateGuestSessionAsync();
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetCreateRequestTokenAsync()
    {
        await ClientFactory.GetClient().Endpoints.Authentication.GetCreateRequestTokenAsync();
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task CreateSessionAsync()
    {
        //CreateSessionRequest postData = ;

        //await ClientFactory.GetClient().Endpoints.Authentication.CreateSessionAsync(postData);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task CreateSessionFromV4TokenAsync()
    {
        //CreateSessionFromV4TokenRequest postData = ;

        //await ClientFactory.GetClient().Endpoints.Authentication.CreateSessionFromV4TokenAsync(postData);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task CreateSessionWithLoginAsync()
    {
        //CreateSessionWithLoginRequest postData = ;

        //await ClientFactory.GetClient().Endpoints.Authentication.CreateSessionWithLoginAsync(postData);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task DeleteDeleteSessionAsync()
    {
        await ClientFactory.GetClient().Endpoints.Authentication.DeleteDeleteSessionAsync();
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetValidateKeyAsync()
    {
        await ClientFactory.GetClient().Endpoints.Authentication.GetValidateKeyAsync();
    }
}
