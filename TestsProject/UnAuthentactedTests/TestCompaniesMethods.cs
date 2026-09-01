namespace TestsProject.UnAuthentactedTests;

[TestClass]
public class TestCompaniesMethods
{
    [TestMethod]
    [DoNotParallelize]
    public async Task GetAlternativeNames()
    {
        int companyId = Constants.PRODUCTION_COMPANY;

        var ret = await ClientFactory.GetClient().Endpoints.Companies.GetAlternativeNamesAsync(companyId);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var item in ret.Data.Results)
            Assert.IsEmpty(item.AdditionalProperties);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetDetails()
    {
        int companyId = Constants.PRODUCTION_COMPANY;

        var ret = await ClientFactory.GetClient().Endpoints.Companies.GetDetailsAsync(companyId);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetImages()
    {
        int companyId = Constants.PRODUCTION_COMPANY;

        var ret = await ClientFactory.GetClient().Endpoints.Companies.GetImagesAsync(companyId);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var item in ret.Data.Logos)
            Assert.IsEmpty(item.AdditionalProperties);
    }
}
