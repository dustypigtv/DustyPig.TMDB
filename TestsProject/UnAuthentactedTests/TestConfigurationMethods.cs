using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsProject.UnAuthentactedTests;

[TestClass]
public class TestConfigurationMethods
{
    [TestMethod]
    [DoNotParallelize]
    public async Task GetCountries()
    {
        string language = Constants.Language;

        await ClientFactory.GetClient().Endpoints.Configuration.GetCountriesAsync(language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetDetails()
    {
        await ClientFactory.GetClient().Endpoints.Configuration.GetDetailsAsync();
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetJobs()
    {
        await ClientFactory.GetClient().Endpoints.Configuration.GetJobsAsync();
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetLanguages()
    {
        await ClientFactory.GetClient().Endpoints.Configuration.GetLanguagesAsync();
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetPrimaryTranslations()
    {
        await ClientFactory.GetClient().Endpoints.Configuration.GetPrimaryTranslationsAsync();
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetTimezones()
    {
        await ClientFactory.GetClient().Endpoints.Configuration.GetTimezonesAsync();
    }
}
