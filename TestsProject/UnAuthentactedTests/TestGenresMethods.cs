namespace TestsProject.UnAuthentactedTests;

[TestClass]
public class TestGenresMethods
{
    [TestMethod]
    [DoNotParallelize]
    public async Task GetMovies()
    {
        string language = Constants.Language;

        var ret = await ClientFactory.GetClient().Endpoints.Genres.GetMoviesAsync(language);
        AdditionalPropertiesChecker.Check(ret);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetTvSeries()
    {
        string language = Constants.Language;

        var ret = await ClientFactory.GetClient().Endpoints.Genres.GetTvSeriesAsync(language);
        AdditionalPropertiesChecker.Check(ret);
    }
}
