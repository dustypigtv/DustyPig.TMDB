using DustyPig.TMDB.Models.Movies;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsProject;

[TestClass]
public class TestMoviesMethods
{
    //[TestMethod]
    [DoNotParallelize]
    public async Task GetAccountStatesAsync()
    {
        int movieId = Constants.MOVIE_ID;
        string guestSessionId = null;
        string sessionId = null;

        await ClientFactory.GetClient().Endpoints.Movies.GetAccountStatesAsync(movieId, guestSessionId, sessionId);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task AddRatingAsync()
    {
        //CommonValue1 postData = ;
        int movieId = Constants.MOVIE_ID;
        string guestSessionId = null;
        string sessionId = null;

        //await ClientFactory.GetClient().Endpoints.Movies.AddRatingAsync(postData, movieId, guestSessionId, sessionId);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetAlternativeTitlesAsync()
    {
        int movieId = Constants.MOVIE_ID;
        string country = null;

        await ClientFactory.GetClient().Endpoints.Movies.GetAlternativeTitlesAsync(movieId, country);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetChangesAsync()
    {
        int movieId = Constants.MOVIE_ID;
        int page = 1;
        DateOnly? endDate = null;
        DateOnly? startDate = null;

        await ClientFactory.GetClient().Endpoints.Movies.GetChangesAsync(movieId, page, endDate, startDate);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetCreditsAsync()
    {
        int movieId = Constants.MOVIE_ID;
        string language = "en-US";

        await ClientFactory.GetClient().Endpoints.Movies.GetCreditsAsync(movieId, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetDetailsAsync()
    {
        int movieId = Constants.MOVIE_ID;
        AppendToResponse? appendToResponse = null;
        string language = "en-US";

        await ClientFactory.GetClient().Endpoints.Movies.GetDetailsAsync(movieId, appendToResponse, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetExternalIdsAsync()
    {
        int movieId = Constants.MOVIE_ID;

        await ClientFactory.GetClient().Endpoints.Movies.GetExternalIdsAsync(movieId);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetImagesAsync()
    {
        int movieId = Constants.MOVIE_ID;
        string includeImageLanguage = null;
        string language = "en-US";

        await ClientFactory.GetClient().Endpoints.Movies.GetImagesAsync(movieId, includeImageLanguage, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetKeywordsAsync()
    {
        //string movieId = ;

        //await ClientFactory.GetClient().Endpoints.Movies.GetKeywordsAsync(movieId);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetLatestAsync()
    {
        await ClientFactory.GetClient().Endpoints.Movies.GetLatestAsync();
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetListsAsync()
    {
        int movieId = Constants.MOVIE_ID;
        int page = 1;
        string language = "en-US";

        await ClientFactory.GetClient().Endpoints.Movies.GetListsAsync(movieId, page, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetRecommendationsAsync()
    {
        int movieId = Constants.MOVIE_ID;
        int page = 1;
        string language = "en-US";

        await ClientFactory.GetClient().Endpoints.Movies.GetRecommendationsAsync(movieId, page, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetReleaseDatesAsync()
    {
        int movieId = Constants.MOVIE_ID;

        await ClientFactory.GetClient().Endpoints.Movies.GetReleaseDatesAsync(movieId);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetReviewsAsync()
    {
        int movieId = Constants.MOVIE_ID;
        int page = 1;
        string language = "en-US";

        await ClientFactory.GetClient().Endpoints.Movies.GetReviewsAsync(movieId, page, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetSimilarAsync()
    {
        int movieId = Constants.MOVIE_ID;
        int page = 1;
        string language = "en-US";

        await ClientFactory.GetClient().Endpoints.Movies.GetSimilarAsync(movieId, page, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetTranslationsAsync()
    {
        int movieId = Constants.MOVIE_ID;

        await ClientFactory.GetClient().Endpoints.Movies.GetTranslationsAsync(movieId);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetVideosAsync()
    {
        int movieId = Constants.MOVIE_ID;
        string language = "en-US";

        await ClientFactory.GetClient().Endpoints.Movies.GetVideosAsync(movieId, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetWatchProvidersAsync()
    {
        int movieId = Constants.MOVIE_ID;

        var ret = await ClientFactory.GetClient().Endpoints.Movies.GetWatchProvidersAsync(movieId);
    }
}
