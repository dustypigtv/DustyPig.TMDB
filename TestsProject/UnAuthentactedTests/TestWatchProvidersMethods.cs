using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsProject.UnAuthentactedTests;

[TestClass]
public class TestWatchProvidersMethods
{
    [TestMethod]
    [DoNotParallelize]
    public async Task GetAvailableRegions()
    {
        string language = Constants.Language;

        await ClientFactory.GetClient().Endpoints.WatchProviders.GetAvailableRegionsAsync(language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetMovieProviders()
    {
        string language = Constants.Language;
        string watchRegion = null;

        await ClientFactory.GetClient().Endpoints.WatchProviders.GetMovieProvidersAsync(language, watchRegion);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetTvSeriesProviders()
    {
        string language = Constants.Language;
        string watchRegion = null;

        await ClientFactory.GetClient().Endpoints.WatchProviders.GetTvSeriesProvidersAsync(language, watchRegion);
    }
}
