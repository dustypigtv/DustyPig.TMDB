using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsProject.UnAuthentactedTests;

[TestClass]
public class TestGenresMethods
{
    [TestMethod]
    [DoNotParallelize]
    public async Task GetMovies()
    {
        string language = Constants.Language;

        await ClientFactory.GetClient().Endpoints.Genres.GetMoviesAsync(language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetTvSeries()
    {
        string language = Constants.Language;

        await ClientFactory.GetClient().Endpoints.Genres.GetTvSeriesAsync(language);
    }
}
