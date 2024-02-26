using DustyPig.TMDB.Models.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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

        await ClientFactory.GetClient().Endpoints.TvSeries.GetAccountStatesAsync(seriesId, guestSessionId, sessionId);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task AddRating()
    {
        string sessionId = Environment.GetEnvironmentVariable("TMDB_API_SESSION_ID");

        CommonValue1 postData = new()
        {
            Value = 10
        };
        int seriesId = Constants.TV_SERIES_ID;
        string guestSessionId = null;

        await ClientFactory.GetClient().Endpoints.TvSeries.AddRatingAsync(postData, seriesId, guestSessionId, sessionId);
    }
}