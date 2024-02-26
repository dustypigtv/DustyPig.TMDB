using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsProject.UnAuthentactedTests;

[TestClass]
public class TestCompaniesMethods
{
    [TestMethod]
    [DoNotParallelize]
    public async Task GetAlternativeNames()
    {
        int companyId = Constants.PRODUCTION_COMPANY;

        await ClientFactory.GetClient().Endpoints.Companies.GetAlternativeNamesAsync(companyId);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetDetails()
    {
        int companyId = Constants.PRODUCTION_COMPANY;

        await ClientFactory.GetClient().Endpoints.Companies.GetDetailsAsync(companyId);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetImages()
    {
        int companyId = Constants.PRODUCTION_COMPANY;

        await ClientFactory.GetClient().Endpoints.Companies.GetImagesAsync(companyId);
    }
}
