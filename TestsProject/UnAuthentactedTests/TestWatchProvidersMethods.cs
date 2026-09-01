namespace TestsProject.UnAuthentactedTests;

[TestClass]
public class TestWatchProvidersMethods
{
    [TestMethod]
    [DoNotParallelize]
    public async Task GetAvailableRegions()
    {
        string language = Constants.Language;

        var ret = await ClientFactory.GetClient().Endpoints.WatchProviders.GetAvailableRegionsAsync(language);
        AdditionalPropertiesChecker.Check(ret);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetMovieProviders()
    {
        string language = Constants.Language;
        string watchRegion = null;

        var ret = await ClientFactory.GetClient().Endpoints.WatchProviders.GetMovieProvidersAsync(language, watchRegion);
        AdditionalPropertiesChecker.Check(ret);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetTvSeriesProviders()
    {
        string language = Constants.Language;
        string watchRegion = null;

        var ret = await ClientFactory.GetClient().Endpoints.WatchProviders.GetTvSeriesProvidersAsync(language, watchRegion);
        AdditionalPropertiesChecker.Check(ret);
    }
}
