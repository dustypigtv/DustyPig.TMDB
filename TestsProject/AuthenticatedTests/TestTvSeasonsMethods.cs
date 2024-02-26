using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsProject.AuthenticatedTests;

[TestClass]
public class TestTvSeasonsMethods
{
    [TestMethod]
    [DoNotParallelize]
    public async Task GetAccountStates()
    {
        string sessionId = Environment.GetEnvironmentVariable("TMDB_API_SESSION_ID");

        int seasonNumber = 5;
        int seriesId = Constants.TV_SERIES_ID;
        string guestSessionId = null;

        await ClientFactory.GetClient().Endpoints.TvSeasons.GetAccountStatesAsync(seasonNumber, seriesId, guestSessionId, sessionId);
    }
}