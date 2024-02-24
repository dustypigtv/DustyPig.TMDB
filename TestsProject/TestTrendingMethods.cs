using DustyPig.TMDB.Models.Trending;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsProject;

[TestClass]
public class TestTrendingMethods
{
    [TestMethod]
    [DoNotParallelize]
    public async Task GetAllAsync()
    {
        Timewindow timeWindow = Timewindow.Day;
        string language = "en-US";

        //await ClientFactory.GetClient().Endpoints.Trending.GetAllAsync(timeWindow, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetMoviesAsync()
    {
        Timewindow timeWindow = Timewindow.Day;
        string language = "en-US";

        //await ClientFactory.GetClient().Endpoints.Trending.GetMoviesAsync(timeWindow, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetPeopleAsync()
    {
        Timewindow timeWindow = Timewindow.Day;
        string language = "en-US";

        //await ClientFactory.GetClient().Endpoints.Trending.GetPeopleAsync(timeWindow, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetTvAsync()
    {
        Timewindow timeWindow = Timewindow.Day;
        string language = "en-US";

        //await ClientFactory.GetClient().Endpoints.Trending.GetTvAsync(timeWindow, language);
    }
}
