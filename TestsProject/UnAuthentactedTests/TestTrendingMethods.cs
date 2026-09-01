using DustyPig.TMDB.Models.Trending;

namespace TestsProject.UnAuthentactedTests;

[TestClass]
public class TestTrendingMethods
{
    [TestMethod]
    [DoNotParallelize]
    public async Task GetAll()
    {
        Timewindow timeWindow = Timewindow.Day;
        string language = Constants.Language;

        var ret = await ClientFactory.GetClient().Endpoints.Trending.GetAllAsync(timeWindow, language);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var item in ret.Data.Movies)
            Assert.IsEmpty(item.AdditionalProperties);
        foreach (var item in ret.Data.People)
            Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var item in ret.Data.Series)
            Assert.IsEmpty(item.AdditionalProperties);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetMovies()
    {
        Timewindow timeWindow = Timewindow.Day;
        string language = Constants.Language;

        var ret = await ClientFactory.GetClient().Endpoints.Trending.GetMoviesAsync(timeWindow, language);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var item in ret.Data.Results)
            Assert.IsEmpty(item.AdditionalProperties);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetPeople()
    {
        Timewindow timeWindow = Timewindow.Day;
        string language = Constants.Language;

        var ret = await ClientFactory.GetClient().Endpoints.Trending.GetPeopleAsync(timeWindow, language);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var item in ret.Data.Results)
        {
            Assert.IsEmpty(item.AdditionalProperties);
            foreach (var item2 in item.KnownFor)
                Assert.IsEmpty(item2.AdditionalProperties);
        }
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetTvSeries()
    {
        Timewindow timeWindow = Timewindow.Day;
        string language = Constants.Language;

        var ret = await ClientFactory.GetClient().Endpoints.Trending.GetTvSeriesAsync(timeWindow, language);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var item in ret.Data.Results)
            Assert.IsEmpty(item.AdditionalProperties);
    }
}
