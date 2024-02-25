using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsProject;

[TestClass]
public class TestGenresMethods
{
    [TestMethod]
    [DoNotParallelize]
    public async Task GetMovieListAsync()
    {
        string language = "en-US";

        await ClientFactory.GetClient().Endpoints.Genres.GetMovieListAsync(language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetTvListAsync()
    {
        string language = "en-US";

        await ClientFactory.GetClient().Endpoints.Genres.GetTvListAsync(language);
    }
}
