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
        foreach (var item in ret.Data)
            Assert.IsEmpty(item.AdditionalProperties);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetDetails()
    {
        var ret = await ClientFactory.GetClient().Endpoints.Configuration.GetDetailsAsync();
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        Assert.IsEmpty(ret.Data.Images.AdditionalProperties);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetJobs()
    {
        var ret = await ClientFactory.GetClient().Endpoints.Configuration.GetJobsAsync();
        foreach (var item in ret.Data)
            Assert.IsEmpty(item.AdditionalProperties);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetLanguages()
    {
        var ret = await ClientFactory.GetClient().Endpoints.Configuration.GetLanguagesAsync();
        foreach (var item in ret.Data)
            Assert.IsEmpty(item.AdditionalProperties);
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
        var ret = await ClientFactory.GetClient().Endpoints.Configuration.GetTimezonesAsync();
        foreach (var item in ret.Data)
            Assert.IsEmpty(item.AdditionalProperties);
    }
}
