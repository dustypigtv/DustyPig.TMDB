using DustyPig.TMDB.Models.TvSeries;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsProject.UnAuthentactedTests;

[TestClass]
public class TestTvSeriesMethods
{
    [TestMethod]
    [DoNotParallelize]
    public async Task GetAggregateCredits()
    {
        int seriesId = Constants.TV_SERIES_ID;
        string language = Constants.Language;

        await ClientFactory.GetClient().Endpoints.TvSeries.GetAggregateCreditsAsync(seriesId, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetAlternativeTitles()
    {
        int seriesId = Constants.TV_SERIES_ID;

        await ClientFactory.GetClient().Endpoints.TvSeries.GetAlternativeTitlesAsync(seriesId);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetChanges()
    {
        int seriesId = Constants.TV_SERIES_ID;
        int page = 1;
        DateOnly? endDate = null;
        DateOnly? startDate = null;

        await ClientFactory.GetClient().Endpoints.TvSeries.GetChangesAsync(seriesId, page, endDate, startDate);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetContentRatings()
    {
        int seriesId = Constants.TV_SERIES_ID;

        await ClientFactory.GetClient().Endpoints.TvSeries.GetContentRatingsAsync(seriesId);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetCredits()
    {
        int seriesId = Constants.TV_SERIES_ID;
        string language = Constants.Language;

        await ClientFactory.GetClient().Endpoints.TvSeries.GetCreditsAsync(seriesId, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetDetails()
    {
        int seriesId = Constants.TV_SERIES_ID;
        AppendToResponse? appendToResponse =
            AppendToResponse.AccountStates |
            AppendToResponse.AggregateCredits |
            AppendToResponse.AlternativeTitles |
            AppendToResponse.Changes |
            AppendToResponse.ContentRatings |
            AppendToResponse.Credits |
            AppendToResponse.EpisodeGroups |
            AppendToResponse.ExternalIds |
            AppendToResponse.Images |
            AppendToResponse.Keywords |
            AppendToResponse.Lists |
            AppendToResponse.Recommendations |
            AppendToResponse.Reviews |
            AppendToResponse.ScreenedTheatrically |
            AppendToResponse.Similar |
            AppendToResponse.Translations |
            AppendToResponse.Videos;
        string language = Constants.Language;

        await ClientFactory.GetClient().Endpoints.TvSeries.GetDetailsAsync(seriesId, appendToResponse, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetEpisodeGroups()
    {
        int seriesId = Constants.TV_SERIES_ID;

        await ClientFactory.GetClient().Endpoints.TvSeries.GetEpisodeGroupsAsync(seriesId);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetExternalIds()
    {
        int seriesId = Constants.TV_SERIES_ID;

        await ClientFactory.GetClient().Endpoints.TvSeries.GetExternalIdsAsync(seriesId);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetImages()
    {
        int seriesId = Constants.TV_SERIES_ID;
        string includeImageLanguage = null;
        string language = Constants.Language;

        await ClientFactory.GetClient().Endpoints.TvSeries.GetImagesAsync(seriesId, includeImageLanguage, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetKeywords()
    {
        int seriesId = Constants.TV_SERIES_ID;

        await ClientFactory.GetClient().Endpoints.TvSeries.GetKeywordsAsync(seriesId);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetLatest()
    {
        await ClientFactory.GetClient().Endpoints.TvSeries.GetLatestAsync();
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetLists()
    {
        int seriesId = Constants.TV_SERIES_ID;
        int page = 1;
        string language = Constants.Language;

        await ClientFactory.GetClient().Endpoints.TvSeries.GetListsAsync(seriesId, page, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetRecommendations()
    {
        int seriesId = Constants.TV_SERIES_ID;
        int page = 1;
        string language = Constants.Language;

        await ClientFactory.GetClient().Endpoints.TvSeries.GetRecommendationsAsync(seriesId, page, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetReviews()
    {
        int seriesId = Constants.TV_SERIES_ID;
        int page = 1;
        string language = Constants.Language;

        await ClientFactory.GetClient().Endpoints.TvSeries.GetReviewsAsync(seriesId, page, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetScreenedTheatrically()
    {
        int seriesId = Constants.TV_SERIES_ID;

        await ClientFactory.GetClient().Endpoints.TvSeries.GetScreenedTheatricallyAsync(seriesId);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetSimilar()
    {
        int seriesId = Constants.TV_SERIES_ID;
        int page = 1;
        string language = Constants.Language;

        await ClientFactory.GetClient().Endpoints.TvSeries.GetSimilarAsync(seriesId, page, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetTranslations()
    {
        int seriesId = Constants.TV_SERIES_ID;

        await ClientFactory.GetClient().Endpoints.TvSeries.GetTranslationsAsync(seriesId);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetVideos()
    {
        int seriesId = Constants.TV_SERIES_ID;
        string includeVideoLanguage = null;
        string language = Constants.Language;

        await ClientFactory.GetClient().Endpoints.TvSeries.GetVideosAsync(seriesId, includeVideoLanguage, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetWatchProviders()
    {
        int seriesId = Constants.TV_SERIES_ID;

        await ClientFactory.GetClient().Endpoints.TvSeries.GetWatchProvidersAsync(seriesId);
    }
}
