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
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var item in ret.Data.Results)
            Assert.IsEmpty(item.AdditionalProperties);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetDetails()
    {
        int networkId = Constants.NETWORK_ID;

        var ret = await ClientFactory.GetClient().Endpoints.Networks.GetDetailsAsync(networkId);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetImages()
    {
        int networkId = Constants.NETWORK_ID;

        var ret = await ClientFactory.GetClient().Endpoints.Networks.GetImagesAsync(networkId);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var item in ret.Data.Logos)
            Assert.IsEmpty(item.AdditionalProperties);
    }
}
