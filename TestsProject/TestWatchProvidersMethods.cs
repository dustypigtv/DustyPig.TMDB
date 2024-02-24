using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsProject;

[TestClass]
public class TestWatchProvidersMethods
{
    [TestMethod]
    [DoNotParallelize]
    public async Task GetAvailableRegionsAsync()
    {
        string language = "en-US";

        //await ClientFactory.GetClient().Endpoints.WatchProviders.GetAvailableRegionsAsync(language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetMovieProvidersAsync()
    {
        string language = "en-US";
        string watchRegion = null;

        //await ClientFactory.GetClient().Endpoints.WatchProviders.GetMovieProvidersAsync(language, watchRegion);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetTvProvidersAsync()
    {
        string language = "en-US";
        string watchRegion = null;

        //await ClientFactory.GetClient().Endpoints.WatchProviders.GetTvProvidersAsync(language, watchRegion);
    }
}
