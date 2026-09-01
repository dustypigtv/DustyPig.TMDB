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
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var item in ret.Data.Results)
            Assert.IsEmpty(item.AdditionalProperties);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetMovieProviders()
    {
        string language = Constants.Language;
        string watchRegion = null;

        var ret = await ClientFactory.GetClient().Endpoints.WatchProviders.GetMovieProvidersAsync(language, watchRegion);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var item in ret.Data.Results)
            Assert.IsEmpty(item.AdditionalProperties);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetTvSeriesProviders()
    {
        string language = Constants.Language;
        string watchRegion = null;

        var ret = await ClientFactory.GetClient().Endpoints.WatchProviders.GetTvSeriesProvidersAsync(language, watchRegion);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var item in ret.Data.Results)
            Assert.IsEmpty(item.AdditionalProperties);
    }
}
