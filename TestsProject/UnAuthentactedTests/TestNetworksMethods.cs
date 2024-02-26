using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsProject.UnAuthentactedTests;

[TestClass]
public class TestNetworksMethods
{
    [TestMethod]
    [DoNotParallelize]
    public async Task GetAlternativeNames()
    {
        int networkId = Constants.NETWORK_ID;

        await ClientFactory.GetClient().Endpoints.Networks.GetAlternativeNamesAsync(networkId);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetDetails()
    {
        int networkId = Constants.NETWORK_ID;

        await ClientFactory.GetClient().Endpoints.Networks.GetDetailsAsync(networkId);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetImages()
    {
        int networkId = Constants.NETWORK_ID;

        await ClientFactory.GetClient().Endpoints.Networks.GetImagesAsync(networkId);
    }
}
