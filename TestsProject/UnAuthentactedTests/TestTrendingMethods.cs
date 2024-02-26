using DustyPig.TMDB.Models.Trending;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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

        await ClientFactory.GetClient().Endpoints.Trending.GetAllAsync(timeWindow, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetMovies()
    {
        Timewindow timeWindow = Timewindow.Day;
        string language = Constants.Language;

        await ClientFactory.GetClient().Endpoints.Trending.GetMoviesAsync(timeWindow, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetPeople()
    {
        Timewindow timeWindow = Timewindow.Day;
        string language = Constants.Language;

        await ClientFactory.GetClient().Endpoints.Trending.GetPeopleAsync(timeWindow, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetTv()
    {
        Timewindow timeWindow = Timewindow.Day;
        string language = Constants.Language;

        await ClientFactory.GetClient().Endpoints.Trending.GetTvAsync(timeWindow, language);
    }
}
