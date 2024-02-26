using DustyPig.TMDB.Models.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsProject.AuthenticatedTests;

//These work randomly - even with 10 second delays.
//The params, urls and bodies have all been tested, the response json can be deserialized...
//I don't need to run these every time

//[TestClass]
public class TestGuestSessionsMethods
{
    [TestMethod]
    [DoNotParallelize]
    public async Task GetRatedMovies()
    {
        var client = ClientFactory.GetClient();
        var createSessionResponse = await client.Endpoints.Authentication.GetCreateGuestSessionAsync();
        var guestSessionId = createSessionResponse.Data.GuestSessionId;

        float rating = 10;
        int movieId = Constants.MOVIE_ID;
        string sessionId = null;

        await client.Endpoints.Movies.AddRatingAsync(rating, movieId, guestSessionId, sessionId);
        await Task.Delay(10_000); //These take a while to propegate for guest sessions

        int page = 1;
        string language = Constants.Language;
        CommonSortByCreated sortBy = CommonSortByCreated.CreatedAtAsc;

        await client.Endpoints.GuestSessions.GetRatedMoviesAsync(guestSessionId, page, language, sortBy);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetRatedTvSeries()
    {
        var client = ClientFactory.GetClient();
        var createSessionResponse = await client.Endpoints.Authentication.GetCreateGuestSessionAsync();
        var guestSessionId = createSessionResponse.Data.GuestSessionId;

        float rating = 10;
        int seriesId = Constants.TV_SERIES_ID;
        string sessionId = null;

        await client.Endpoints.TvSeries.AddRatingAsync(rating, seriesId, guestSessionId, sessionId);
        await Task.Delay(10_000); //These take a while to propegate for guest sessions


        int page = 1;
        string language = Constants.Language;
        CommonSortByCreated sortBy = CommonSortByCreated.CreatedAtAsc;

        await client.Endpoints.GuestSessions.GetRatedTvSeriesAsync(guestSessionId, page, language, sortBy);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetRatedTvEpisodes()
    {
        var client = ClientFactory.GetClient();
        var createSessionResponse = await client.Endpoints.Authentication.GetCreateGuestSessionAsync();
        var guestSessionId = createSessionResponse.Data.GuestSessionId;

        float rating = 10;
        int episodeNumber = 1;
        int seasonNumber = 5;
        int seriesId = Constants.TV_SERIES_ID;
        string sessionId = null;

        await client.Endpoints.TvEpisodes.AddRatingAsync(rating, episodeNumber, seasonNumber, seriesId, guestSessionId, sessionId);
        await Task.Delay(10_000); //These take a while to propegate for guest sessions


        int page = 1;
        string language = Constants.Language;
        CommonSortByCreated sortBy = CommonSortByCreated.CreatedAtAsc;

        await client.Endpoints.GuestSessions.GetRatedTvEpisodesAsync(guestSessionId, page, language, sortBy);
    }
}
