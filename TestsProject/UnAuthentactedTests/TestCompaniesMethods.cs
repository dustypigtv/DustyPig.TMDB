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
        AdditionalPropertiesChecker.Check(ret);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetDetails()
    {
        int companyId = Constants.PRODUCTION_COMPANY;

        var ret = await ClientFactory.GetClient().Endpoints.Companies.GetDetailsAsync(companyId);
        AdditionalPropertiesChecker.Check(ret);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetImages()
    {
        int companyId = Constants.PRODUCTION_COMPANY;

        var ret = await ClientFactory.GetClient().Endpoints.Companies.GetImagesAsync(companyId);
        AdditionalPropertiesChecker.Check(ret);
    }
}
