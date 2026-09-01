namespace TestsProject.UnAuthentactedTests;

[TestClass]
public class TestMovieListsMethods
{
    [TestMethod]
    [DoNotParallelize]
    public async Task GetNowPlaying()
    {
        int page = 1;
        string language = Constants.Language;
        string region = null;

        var ret = await ClientFactory.GetClient().Endpoints.MovieLists.GetNowPlayingAsync(page, language, region);
        AdditionalPropertiesChecker.Check(ret);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetPopular()
    {
        int page = 1;
        string language = Constants.Language;
        string region = null;

        var ret = await ClientFactory.GetClient().Endpoints.MovieLists.GetPopularAsync(page, language, region);
        AdditionalPropertiesChecker.Check(ret);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetTopRated()
    {
        int page = 1;
        string language = Constants.Language;
        string region = null;

        var ret = await ClientFactory.GetClient().Endpoints.MovieLists.GetTopRatedAsync(page, language, region);
        AdditionalPropertiesChecker.Check(ret);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetUpcoming()
    {
        int page = 1;
        string language = Constants.Language;
        string region = null;

        var ret = await ClientFactory.GetClient().Endpoints.MovieLists.GetUpcomingAsync(page, language, region);
        AdditionalPropertiesChecker.Check(ret);
    }
}
