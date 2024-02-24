using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsProject;

[TestClass]
public class TestConfigurationMethods
{
    [TestMethod]
    [DoNotParallelize]
    public async Task GetCountriesAsync()
    {
        string language = "en-US";

        await ClientFactory.GetClient().Endpoints.Configuration.GetCountriesAsync(language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetDetailsAsync()
    {
        await ClientFactory.GetClient().Endpoints.Configuration.GetDetailsAsync();
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetJobsAsync()
    {
        await ClientFactory.GetClient().Endpoints.Configuration.GetJobsAsync();
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetLanguagesAsync()
    {
        await ClientFactory.GetClient().Endpoints.Configuration.GetLanguagesAsync();
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetPrimaryTranslationsAsync()
    {
        await ClientFactory.GetClient().Endpoints.Configuration.GetPrimaryTranslationsAsync();
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetTimezonesAsync()
    {
        await ClientFactory.GetClient().Endpoints.Configuration.GetTimezonesAsync();
    }
}
