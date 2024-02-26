using DustyPig.TMDB.Models.Movies;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsProject.UnAuthentactedTests;

[TestClass]
public class TestMoviesMethods
{
    [TestMethod]
    [DoNotParallelize]
    public async Task GetAlternativeTitles()
    {
        int movieId = Constants.MOVIE_ID;
        string country = null;

        await ClientFactory.GetClient().Endpoints.Movies.GetAlternativeTitlesAsync(movieId, country);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetChanges()
    {
        int movieId = Constants.MOVIE_ID;
        int page = 1;
        DateOnly? endDate = null;
        DateOnly? startDate = null;

        await ClientFactory.GetClient().Endpoints.Movies.GetChangesAsync(movieId, page, endDate, startDate);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetCredits()
    {
        int movieId = Constants.MOVIE_ID;
        string language = Constants.Language;

        await ClientFactory.GetClient().Endpoints.Movies.GetCreditsAsync(movieId, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetDetails()
    {
        int movieId = Constants.MOVIE_ID;
        AppendToResponse? appendToResponse =
            AppendToResponse.AlternativeTitles |
            AppendToResponse.Changes |
            AppendToResponse.Credits |
            AppendToResponse.ExternalIds |
            AppendToResponse.Images |
            AppendToResponse.Keywords |
            AppendToResponse.Lists |
            AppendToResponse.Recommendations |
            AppendToResponse.ReleaseDates |
            AppendToResponse.Reviews |
            AppendToResponse.Similar |
            AppendToResponse.Translations |
            AppendToResponse.Videos;

        string language = Constants.Language;

        await ClientFactory.GetClient().Endpoints.Movies.GetDetailsAsync(movieId, appendToResponse, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetExternalIds()
    {
        int movieId = Constants.MOVIE_ID;

        await ClientFactory.GetClient().Endpoints.Movies.GetExternalIdsAsync(movieId);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetImages()
    {
        int movieId = Constants.MOVIE_ID;
        string includeImageLanguage = null;
        string language = Constants.Language;

        await ClientFactory.GetClient().Endpoints.Movies.GetImagesAsync(movieId, includeImageLanguage, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetKeywords()
    {
        int movieId = Constants.MOVIE_ID;

        await ClientFactory.GetClient().Endpoints.Movies.GetKeywordsAsync(movieId);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetLatest()
    {
        await ClientFactory.GetClient().Endpoints.Movies.GetLatestAsync();
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetLists()
    {
        int movieId = Constants.MOVIE_ID;
        int page = 1;
        string language = Constants.Language;

        await ClientFactory.GetClient().Endpoints.Movies.GetListsAsync(movieId, page, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetRecommendations()
    {
        int movieId = Constants.MOVIE_ID;
        int page = 1;
        string language = Constants.Language;

        await ClientFactory.GetClient().Endpoints.Movies.GetRecommendationsAsync(movieId, page, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetReleaseDates()
    {
        int movieId = Constants.MOVIE_ID;

        await ClientFactory.GetClient().Endpoints.Movies.GetReleaseDatesAsync(movieId);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetReviews()
    {
        int movieId = Constants.MOVIE_ID;
        int page = 1;
        string language = Constants.Language;

        await ClientFactory.GetClient().Endpoints.Movies.GetReviewsAsync(movieId, page, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetSimilar()
    {
        int movieId = Constants.MOVIE_ID;
        int page = 1;
        string language = Constants.Language;

        await ClientFactory.GetClient().Endpoints.Movies.GetSimilarAsync(movieId, page, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetTranslations()
    {
        int movieId = Constants.MOVIE_ID;

        await ClientFactory.GetClient().Endpoints.Movies.GetTranslationsAsync(movieId);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetVideos()
    {
        int movieId = Constants.MOVIE_ID;
        string language = Constants.Language;

        await ClientFactory.GetClient().Endpoints.Movies.GetVideosAsync(movieId, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetWatchProviders()
    {
        int movieId = Constants.MOVIE_ID;

        await ClientFactory.GetClient().Endpoints.Movies.GetWatchProvidersAsync(movieId);
    }
}
