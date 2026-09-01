namespace TestsProject.AuthenticatedTests;

[TestClass]
public class TestTvSeriesMethods
{
    [TestMethod]
    [DoNotParallelize]
    public async Task GetAccountStates()
    {
        string sessionId = Environment.GetEnvironmentVariable("TMDB_API_SESSION_ID");

        int seriesId = Constants.TV_SERIES_ID;
        string guestSessionId = null;

        var ret = await ClientFactory.GetClient().Endpoints.TvSeries.GetAccountStatesAsync(seriesId, guestSessionId, sessionId);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task AddRating()
    {
        string sessionId = Environment.GetEnvironmentVariable("TMDB_API_SESSION_ID");

        float rating = 10;
        int seriesId = Constants.TV_SERIES_ID;
        string guestSessionId = null;

        var ret = await ClientFactory.GetClient().Endpoints.TvSeries.AddRatingAsync(rating, seriesId, guestSessionId, sessionId);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
    }

    [TestMethod]
    [DoNotParallelize]
    public async Task DeleteRating()
    {
        string sessionId = Environment.GetEnvironmentVariable("TMDB_API_SESSION_ID");

        int seriesId = Constants.TV_SERIES_ID;
        string guestSessionId = null;

        var ret = await ClientFactory.GetClient().Endpoints.TvSeries.DeleteRatingAsync(seriesId, guestSessionId, sessionId);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
    }
}