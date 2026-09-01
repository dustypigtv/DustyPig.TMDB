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
        AdditionalPropertiesChecker.Check(ret);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetMovies()
    {
        Timewindow timeWindow = Timewindow.Day;
        string language = Constants.Language;

        var ret = await ClientFactory.GetClient().Endpoints.Trending.GetMoviesAsync(timeWindow, language);
        AdditionalPropertiesChecker.Check(ret);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetPeople()
    {
        Timewindow timeWindow = Timewindow.Day;
        string language = Constants.Language;

        var ret = await ClientFactory.GetClient().Endpoints.Trending.GetPeopleAsync(timeWindow, language);
        AdditionalPropertiesChecker.Check(ret);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetTvSeries()
    {
        Timewindow timeWindow = Timewindow.Day;
        string language = Constants.Language;

        var ret = await ClientFactory.GetClient().Endpoints.Trending.GetTvSeriesAsync(timeWindow, language);
        AdditionalPropertiesChecker.Check(ret);
    }
}
