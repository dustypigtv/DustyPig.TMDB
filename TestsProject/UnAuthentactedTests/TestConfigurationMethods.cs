namespace TestsProject.UnAuthentactedTests;

[TestClass]
public class TestConfigurationMethods
{
    [TestMethod]
    [DoNotParallelize]
    public async Task GetCountries()
    {
        string language = Constants.Language;

        var ret = await ClientFactory.GetClient().Endpoints.Configuration.GetCountriesAsync(language);
        AdditionalPropertiesChecker.Check(ret);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetDetails()
    {
        var ret = await ClientFactory.GetClient().Endpoints.Configuration.GetDetailsAsync();
        AdditionalPropertiesChecker.Check(ret);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetJobs()
    {
        var ret = await ClientFactory.GetClient().Endpoints.Configuration.GetJobsAsync();
        AdditionalPropertiesChecker.Check(ret);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetLanguages()
    {
        var ret = await ClientFactory.GetClient().Endpoints.Configuration.GetLanguagesAsync();
        AdditionalPropertiesChecker.Check(ret);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetPrimaryTranslations()
    {
        var ret = await ClientFactory.GetClient().Endpoints.Configuration.GetPrimaryTranslationsAsync();
        AdditionalPropertiesChecker.Check(ret);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetTimezones()
    {
        var ret = await ClientFactory.GetClient().Endpoints.Configuration.GetTimezonesAsync();
        AdditionalPropertiesChecker.Check(ret);
    }
}
