namespace TestsProject.UnAuthentactedTests;

[TestClass]
public class TestCreditsMethods
{
    [TestMethod]
    [DoNotParallelize]
    public async Task GetMovieDetails()
    {
        string creditId = Constants.MOVIE_CREDIT_ID;

        var ret = await ClientFactory.GetClient().Endpoints.Credits.GetDetailsAsync(creditId);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        if(ret.Data.MovieMedia != null)
            Assert.IsEmpty(ret.Data.MovieMedia.AdditionalProperties);
        if(ret.Data.TvMedia != null)
            Assert.IsEmpty(ret.Data.TvMedia.AdditionalProperties);
        Assert.IsEmpty(ret.Data.Person.AdditionalProperties);
    }

    [TestMethod]
    [DoNotParallelize]
    public async Task GetTvDetails()
    {
        string creditId = Constants.TV_CREDIT_ID;

        var ret = await ClientFactory.GetClient().Endpoints.Credits.GetDetailsAsync(creditId);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        if (ret.Data.MovieMedia != null)
            Assert.IsEmpty(ret.Data.MovieMedia.AdditionalProperties);
        if (ret.Data.TvMedia != null)
        {
            Assert.IsEmpty(ret.Data.TvMedia.AdditionalProperties);
            foreach (var item in ret.Data.TvMedia.Episodes)
                Assert.IsEmpty(item.AdditionalProperties);
            foreach (var item in ret.Data.TvMedia.Seasons)
                Assert.IsEmpty(item.AdditionalProperties);
        }
        Assert.IsEmpty(ret.Data.Person.AdditionalProperties);
    }
}
