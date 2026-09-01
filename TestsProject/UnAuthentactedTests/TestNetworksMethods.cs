namespace TestsProject.UnAuthentactedTests;

[TestClass]
public class TestNetworksMethods
{
    [TestMethod]
    [DoNotParallelize]
    public async Task GetAlternativeNames()
    {
        int networkId = Constants.NETWORK_ID;

        var ret = await ClientFactory.GetClient().Endpoints.Networks.GetAlternativeNamesAsync(networkId);
        AdditionalPropertiesChecker.Check(ret);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetDetails()
    {
        int networkId = Constants.NETWORK_ID;

        var ret = await ClientFactory.GetClient().Endpoints.Networks.GetDetailsAsync(networkId);
        AdditionalPropertiesChecker.Check(ret);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetImages()
    {
        int networkId = Constants.NETWORK_ID;

        var ret = await ClientFactory.GetClient().Endpoints.Networks.GetImagesAsync(networkId);
        AdditionalPropertiesChecker.Check(ret);
    }
}
