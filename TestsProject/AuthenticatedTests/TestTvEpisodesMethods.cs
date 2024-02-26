using DustyPig.TMDB.Models.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsProject.AuthenticatedTests;

[TestClass]
public class TestTvEpisodesMethods
{
    [TestMethod]
    [DoNotParallelize]
    public async Task GetAccountStates()
    {
        string sessionId = Environment.GetEnvironmentVariable("TMDB_API_SESSION_ID");

        int episodeNumber = 1;
        int seasonNumber = 5;
        int seriesId = Constants.TV_SERIES_ID;
        string guestSessionId = null;

        await ClientFactory.GetClient().Endpoints.TvEpisodes.GetAccountStatesAsync(episodeNumber, seasonNumber, seriesId, guestSessionId, sessionId);
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
        int episodeNumber = 1;
        int seasonNumber = 5;
        int seriesId = Constants.TV_SERIES_ID;
        string guestSessionId = null;

        await ClientFactory.GetClient().Endpoints.TvEpisodes.AddRatingAsync(postData, episodeNumber, seasonNumber, seriesId, guestSessionId, sessionId);
    }

    [TestMethod]
    [DoNotParallelize]
    public async Task DeleteRating()
    {
        string sessionId = Environment.GetEnvironmentVariable("TMDB_API_SESSION_ID");

        int episodeNumber = 1;
        int seasonNumber = 5;
        int seriesId = Constants.TV_SERIES_ID;
        string guestSessionId = null;

        await ClientFactory.GetClient().Endpoints.TvEpisodes.DeleteRatingAsync(episodeNumber, seasonNumber, seriesId, guestSessionId, sessionId);
    }
}