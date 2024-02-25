using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsProject;

[TestClass]
public class TestMovieListsMethods
{
    [TestMethod]
    [DoNotParallelize]
    public async Task GetNowPlayingAsync()
    {
        int page = 1;
        string language = "en-US";
        string region = null;

        await ClientFactory.GetClient().Endpoints.MovieLists.GetNowPlayingAsync(page, language, region);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetPopularAsync()
    {
        int page = 1;
        string language = "en-US";
        string region = null;

        await ClientFactory.GetClient().Endpoints.MovieLists.GetPopularAsync(page, language, region);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetTopRatedAsync()
    {
        int page = 1;
        string language = "en-US";
        string region = null;

        await ClientFactory.GetClient().Endpoints.MovieLists.GetTopRatedAsync(page, language, region);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetUpcomingAsync()
    {
        int page = 1;
        string language = "en-US";
        string region = null;

        await ClientFactory.GetClient().Endpoints.MovieLists.GetUpcomingAsync(page, language, region);
    }
}
