using DustyPig.TMDB.Models.Movies;

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

        var ret = await ClientFactory.GetClient().Endpoints.Movies.GetAlternativeTitlesAsync(movieId, country);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var item in ret.Data.Titles)
            Assert.IsEmpty(item.AdditionalProperties);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetChanges()
    {
        int movieId = Constants.MOVIE_ID;
        int page = 1;
        DateOnly? endDate = null;
        DateOnly? startDate = null;

        var ret = await ClientFactory.GetClient().Endpoints.Movies.GetChangesAsync(movieId, page, endDate, startDate);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var item in ret.Data.Changes)
        {
            Assert.IsEmpty(item.AdditionalProperties);
            foreach (var item2 in item.Items)
                Assert.IsEmpty(item2.AdditionalProperties);
        }
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetCredits()
    {
        int movieId = Constants.MOVIE_ID;
        string language = Constants.Language;

        var ret = await ClientFactory.GetClient().Endpoints.Movies.GetCreditsAsync(movieId, language);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var item in ret.Data.Cast)
            Assert.IsEmpty(item.AdditionalProperties);
        foreach (var item in ret.Data.Crew)
            Assert.IsEmpty(item.AdditionalProperties);
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

        var ret = await ClientFactory.GetClient().Endpoints.Movies.GetDetailsAsync(movieId, appendToResponse, language);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        Assert.IsEmpty(ret.Data.AccountStates.AdditionalProperties);
        Assert.IsEmpty(ret.Data.Changes.AdditionalProperties);
        foreach (var item in ret.Data.Changes.Changes)
        {
            Assert.IsEmpty(item.AdditionalProperties);
            foreach (var item2 in item.Items)
                Assert.IsEmpty(item2.AdditionalProperties);
        }
        Assert.IsEmpty(ret.Data.Credits.AdditionalProperties);
        foreach (var item in ret.Data.Credits.Crew)
            Assert.IsEmpty(item.AdditionalProperties);
        foreach (var item in ret.Data.Credits.Cast)
            Assert.IsEmpty(item.AdditionalProperties);
        Assert.IsEmpty(ret.Data.ExternalIds.AdditionalProperties);
        foreach (var item in ret.Data.Genres)
            Assert.IsEmpty(item.AdditionalProperties);
        Assert.IsEmpty(ret.Data.Images.AdditionalProperties);
        foreach (var item in ret.Data.Images.Posters)
            Assert.IsEmpty(item.AdditionalProperties);
        foreach (var item in ret.Data.Images.Backdrops)
            Assert.IsEmpty(item.AdditionalProperties);
        foreach (var item in ret.Data.Images.Logos)
            Assert.IsEmpty(item.AdditionalProperties);
        Assert.IsEmpty(ret.Data.Keywords.AdditionalProperties);
        foreach (var item in ret.Data.Keywords.Keywords)
            Assert.IsEmpty(item.AdditionalProperties);
        Assert.IsEmpty(ret.Data.Lists.AdditionalProperties);
        foreach (var item in ret.Data.Lists.Results)
            Assert.IsEmpty(item.AdditionalProperties);
        foreach (var item in ret.Data.ProductionCompanies)
            Assert.IsEmpty(item.AdditionalProperties);
        foreach (var item in ret.Data.ProductionCountries)
            Assert.IsEmpty(item.AdditionalProperties);
        Assert.IsEmpty(ret.Data.Recommendations.AdditionalProperties);
        foreach (var item in ret.Data.Recommendations.Results)
            Assert.IsEmpty(item.AdditionalProperties);
        Assert.IsEmpty(ret.Data.ReleaseDates.AdditionalProperties);
        foreach (var item in ret.Data.ReleaseDates.Results)
        {
            Assert.IsEmpty(item.AdditionalProperties);
            foreach (var item2 in item.ReleaseDates)
                Assert.IsEmpty(item2.AdditionalProperties);
        }
        Assert.IsEmpty(ret.Data.Reviews.AdditionalProperties);
        foreach (var item in ret.Data.Reviews.Results)
        {
            Assert.IsEmpty(item.AdditionalProperties);
            Assert.IsEmpty(item.AuthorDetails.AdditionalProperties);
        }
        Assert.IsEmpty(ret.Data.Similar.AdditionalProperties);
        foreach (var item in ret.Data.Similar.Results)
            Assert.IsEmpty(item.AdditionalProperties);
        foreach (var item in ret.Data.SpokenLanguages)
            Assert.IsEmpty(item.AdditionalProperties);
        Assert.IsEmpty(ret.Data.Translations.AdditionalProperties);
        foreach (var item in ret.Data.Translations.Translations)
        {
            Assert.IsEmpty(item.AdditionalProperties);
            Assert.IsEmpty(item.Data.AdditionalProperties);
        }
        Assert.IsEmpty(ret.Data.Videos.AdditionalProperties);
        foreach (var item in ret.Data.Videos.Results)
            Assert.IsEmpty(item.AdditionalProperties);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetExternalIds()
    {
        int movieId = Constants.MOVIE_ID;

        var ret = await ClientFactory.GetClient().Endpoints.Movies.GetExternalIdsAsync(movieId);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetImages()
    {
        int movieId = Constants.MOVIE_ID;
        string includeImageLanguage = null;
        string language = Constants.Language;

        var ret = await ClientFactory.GetClient().Endpoints.Movies.GetImagesAsync(movieId, includeImageLanguage, language);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var item in ret.Data.Backdrops)
            Assert.IsEmpty(item.AdditionalProperties);
        foreach (var item in ret.Data.Logos)
            Assert.IsEmpty(item.AdditionalProperties);
        foreach (var item in ret.Data.Posters)
            Assert.IsEmpty(item.AdditionalProperties);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetKeywords()
    {
        int movieId = Constants.MOVIE_ID;

        var ret = await ClientFactory.GetClient().Endpoints.Movies.GetKeywordsAsync(movieId);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var item in ret.Data.Keywords)
            Assert.IsEmpty(item.AdditionalProperties);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetLatest()
    {
        var ret = await ClientFactory.GetClient().Endpoints.Movies.GetLatestAsync();
        Assert.IsEmpty(ret.Data.AdditionalProperties);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetLists()
    {
        int movieId = Constants.MOVIE_ID;
        int page = 1;
        string language = Constants.Language;

        var ret = await ClientFactory.GetClient().Endpoints.Movies.GetListsAsync(movieId, page, language);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var item in ret.Data.Results)
            Assert.IsEmpty(item.AdditionalProperties);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetRecommendations()
    {
        int movieId = Constants.MOVIE_ID;
        int page = 1;
        string language = Constants.Language;

        var ret = await ClientFactory.GetClient().Endpoints.Movies.GetRecommendationsAsync(movieId, page, language);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var item in ret.Data.Results)
            Assert.IsEmpty(item.AdditionalProperties);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetReleaseDates()
    {
        int movieId = Constants.MOVIE_ID;

        var ret = await ClientFactory.GetClient().Endpoints.Movies.GetReleaseDatesAsync(movieId);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var item in ret.Data.Results)
        {
            Assert.IsEmpty(item.AdditionalProperties);
            foreach (var item2 in item.ReleaseDates)
                Assert.IsEmpty(item2.AdditionalProperties);
        }
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetReviews()
    {
        int movieId = Constants.MOVIE_ID;
        int page = 1;
        string language = Constants.Language;

        var ret = await ClientFactory.GetClient().Endpoints.Movies.GetReviewsAsync(movieId, page, language);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var item in ret.Data.Results)
        {
            Assert.IsEmpty(item.AdditionalProperties);
            Assert.IsEmpty(item.AuthorDetails.AdditionalProperties);
        }
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetSimilar()
    {
        int movieId = Constants.MOVIE_ID;
        int page = 1;
        string language = Constants.Language;

        var ret = await ClientFactory.GetClient().Endpoints.Movies.GetSimilarAsync(movieId, page, language);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var item in ret.Data.Results)
            Assert.IsEmpty(item.AdditionalProperties);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetTranslations()
    {
        int movieId = Constants.MOVIE_ID;

        var ret = await ClientFactory.GetClient().Endpoints.Movies.GetTranslationsAsync(movieId);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var item in ret.Data.Translations)
            Assert.IsEmpty(item.AdditionalProperties);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetVideos()
    {
        int movieId = Constants.MOVIE_ID;
        string language = Constants.Language;

        var ret = await ClientFactory.GetClient().Endpoints.Movies.GetVideosAsync(movieId, language);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var item in ret.Data.Results)
            Assert.IsEmpty(item.AdditionalProperties);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetWatchProviders()
    {
        int movieId = Constants.MOVIE_ID;

        var ret = await ClientFactory.GetClient().Endpoints.Movies.GetWatchProvidersAsync(movieId);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var key in ret.Data.Result.Keys)
        {
            Assert.IsEmpty(ret.Data.Result[key].AdditionalProperties);
            foreach (var item in ret.Data.Result[key].Ads)
                Assert.IsEmpty(item.AdditionalProperties);
            foreach (var item in ret.Data.Result[key].Buy)
                Assert.IsEmpty(item.AdditionalProperties);
            foreach (var item in ret.Data.Result[key].Flatrate)
                Assert.IsEmpty(item.AdditionalProperties);
            foreach (var item in ret.Data.Result[key].Free)
                Assert.IsEmpty(item.AdditionalProperties);
            foreach (var item in ret.Data.Result[key].Rent)
                Assert.IsEmpty(item.AdditionalProperties);
        }
    }
}
