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
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var item in ret.Data.Genres)
            Assert.IsEmpty(item.AdditionalProperties);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetTvSeries()
    {
        string language = Constants.Language;

        var ret = await ClientFactory.GetClient().Endpoints.Genres.GetTvSeriesAsync(language);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var item in ret.Data.Genres)
            Assert.IsEmpty(item.AdditionalProperties);
    }
}
