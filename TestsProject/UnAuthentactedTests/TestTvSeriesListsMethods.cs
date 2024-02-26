using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsProject.UnAuthentactedTests;

[TestClass]
public class TestTvSeriesListsMethods
{
    [TestMethod]
    [DoNotParallelize]
    public async Task GetAiringToday()
    {
        int page = 1;
        string language = Constants.Language;
        string timezone = null;

        await ClientFactory.GetClient().Endpoints.TvSeriesLists.GetAiringTodayAsync(page, language, timezone);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetOnTheAir()
    {
        int page = 1;
        string language = Constants.Language;
        string timezone = null;

        await ClientFactory.GetClient().Endpoints.TvSeriesLists.GetOnTheAirAsync(page, language, timezone);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetPopular()
    {
        int page = 1;
        string language = Constants.Language;

        await ClientFactory.GetClient().Endpoints.TvSeriesLists.GetPopularAsync(page, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetTopRated()
    {
        int page = 1;
        string language = Constants.Language;

        await ClientFactory.GetClient().Endpoints.TvSeriesLists.GetTopRatedAsync(page, language);
    }
}
