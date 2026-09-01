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

        var ret = await ClientFactory.GetClient().Endpoints.TvSeriesLists.GetAiringTodayAsync(page, language, timezone);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var item in ret.Data.Results)
            Assert.IsEmpty(item.AdditionalProperties);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetOnTheAir()
    {
        int page = 1;
        string language = Constants.Language;
        string timezone = null;

        var ret = await ClientFactory.GetClient().Endpoints.TvSeriesLists.GetOnTheAirAsync(page, language, timezone);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var item in ret.Data.Results)
            Assert.IsEmpty(item.AdditionalProperties);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetPopular()
    {
        int page = 1;
        string language = Constants.Language;

        var ret = await ClientFactory.GetClient().Endpoints.TvSeriesLists.GetPopularAsync(page, language);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var item in ret.Data.Results)
            Assert.IsEmpty(item.AdditionalProperties);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetTopRated()
    {
        int page = 1;
        string language = Constants.Language;

        var ret = await ClientFactory.GetClient().Endpoints.TvSeriesLists.GetTopRatedAsync(page, language);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var item in ret.Data.Results)
            Assert.IsEmpty(item.AdditionalProperties);
    }
}
