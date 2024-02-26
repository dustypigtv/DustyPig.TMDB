using DustyPig.TMDB.Models.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsProject.AuthenticatedTests;

[TestClass]
public class TestMoviesMethods
{
    [TestMethod]
    [DoNotParallelize]
    public async Task GetAccountStates()
    {
        string sessionId = Environment.GetEnvironmentVariable("TMDB_API_SESSION_ID");

        int movieId = Constants.MOVIE_ID;
        string guestSessionId = null;

        await ClientFactory.GetClient().Endpoints.Movies.GetAccountStatesAsync(movieId, guestSessionId, sessionId);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task AddRating()
    {
        string sessionId = Environment.GetEnvironmentVariable("TMDB_API_SESSION_ID");

        float rating = 10;
        int movieId = Constants.MOVIE_ID;
        string guestSessionId = null;

        await ClientFactory.GetClient().Endpoints.Movies.AddRatingAsync(rating, movieId, guestSessionId, sessionId);
    }


    [TestMethod]
    [DoNotParallelize]
    public async Task DeleteRating()
    {
        string sessionId = Environment.GetEnvironmentVariable("TMDB_API_SESSION_ID");

        int movieId = Constants.MOVIE_ID;
        string guestSessionId = null;

        await ClientFactory.GetClient().Endpoints.Movies.DeleteRatingAsync(movieId, guestSessionId, sessionId);
    }
}