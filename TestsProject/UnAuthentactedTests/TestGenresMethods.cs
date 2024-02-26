using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsProject.UnAuthentactedTests;

[TestClass]
public class TestGenresMethods
{
    [TestMethod]
    [DoNotParallelize]
    public async Task GetMovieList()
    {
        string language = Constants.Language;

        await ClientFactory.GetClient().Endpoints.Genres.GetMovieListAsync(language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetTvList()
    {
        string language = Constants.Language;

        await ClientFactory.GetClient().Endpoints.Genres.GetTvListAsync(language);
    }
}
