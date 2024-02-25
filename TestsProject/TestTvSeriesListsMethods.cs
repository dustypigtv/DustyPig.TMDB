using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsProject;

[TestClass]
public class TestTvSeriesListsMethods
{
    [TestMethod]
    [DoNotParallelize]
    public async Task GetAiringTodayAsync()
    {
        int page = 1;
        string language = "en-US";
        string timezone = null;

        await ClientFactory.GetClient().Endpoints.TvSeriesLists.GetAiringTodayAsync(page, language, timezone);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetOnTheAirAsync()
    {
        int page = 1;
        string language = "en-US";
        string timezone = null;

        await ClientFactory.GetClient().Endpoints.TvSeriesLists.GetOnTheAirAsync(page, language, timezone);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetPopularAsync()
    {
        int page = 1;
        string language = "en-US";

        await ClientFactory.GetClient().Endpoints.TvSeriesLists.GetPopularAsync(page, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetTopRatedAsync()
    {
        int page = 1;
        string language = "en-US";

        await ClientFactory.GetClient().Endpoints.TvSeriesLists.GetTopRatedAsync(page, language);
    }
}
