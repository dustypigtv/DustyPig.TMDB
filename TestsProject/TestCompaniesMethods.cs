using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsProject;

[TestClass]
public class TestCompaniesMethods
{
    [TestMethod]
    [DoNotParallelize]
    public async Task GetAlternativeNamesAsync()
    {
        int companyId = Constants.PRODUCTION_COMPANY;

        await ClientFactory.GetClient().Endpoints.Companies.GetAlternativeNamesAsync(companyId);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetDetailsAsync()
    {
        int companyId = Constants.PRODUCTION_COMPANY;

        await ClientFactory.GetClient().Endpoints.Companies.GetDetailsAsync(companyId);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetImagesAsync()
    {
        int companyId = Constants.PRODUCTION_COMPANY;

        await ClientFactory.GetClient().Endpoints.Companies.GetImagesAsync(companyId);
    }
}
