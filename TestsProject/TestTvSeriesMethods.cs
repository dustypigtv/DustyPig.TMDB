using DustyPig.TMDB.Models.TvSeries;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsProject;

[TestClass]
public class TestTvSeriesMethods
{
    //[TestMethod]
    [DoNotParallelize]
    public async Task GetAccountStatesAsync()
    {
        int seriesId = Constants.TV_SERIES_ID;
        string guestSessionId = null;
        string sessionId = null;

        await ClientFactory.GetClient().Endpoints.TvSeries.GetAccountStatesAsync(seriesId, guestSessionId, sessionId);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task AddRatingAsync()
    {
        //CommonValue1 postData = ;
        int seriesId = Constants.TV_SERIES_ID;
        string guestSessionId = null;
        string sessionId = null;

        //await ClientFactory.GetClient().Endpoints.TvSeries.AddRatingAsync(postData, seriesId, guestSessionId, sessionId);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetAggregateCreditsAsync()
    {
        int seriesId = Constants.TV_SERIES_ID;
        string language = "en-US";

        await ClientFactory.GetClient().Endpoints.TvSeries.GetAggregateCreditsAsync(seriesId, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetAlternativeTitlesAsync()
    {
        int seriesId = Constants.TV_SERIES_ID;

        await ClientFactory.GetClient().Endpoints.TvSeries.GetAlternativeTitlesAsync(seriesId);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetChangesAsync()
    {
        int seriesId = Constants.TV_SERIES_ID;
        int page = 1;
        DateOnly? endDate = null;
        DateOnly? startDate = null;

        await ClientFactory.GetClient().Endpoints.TvSeries.GetChangesAsync(seriesId, page, endDate, startDate);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetContentRatingsAsync()
    {
        int seriesId = Constants.TV_SERIES_ID;

        await ClientFactory.GetClient().Endpoints.TvSeries.GetContentRatingsAsync(seriesId);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetCreditsAsync()
    {
        int seriesId = Constants.TV_SERIES_ID;
        string language = "en-US";

        await ClientFactory.GetClient().Endpoints.TvSeries.GetCreditsAsync(seriesId, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetDetailsAsync()
    {
        int seriesId = Constants.TV_SERIES_ID;
        AppendToResponse? appendToResponse = null;
        string language = "en-US";

        await ClientFactory.GetClient().Endpoints.TvSeries.GetDetailsAsync(seriesId, appendToResponse, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetEpisodeGroupsAsync()
    {
        int seriesId = Constants.TV_SERIES_ID;

        await ClientFactory.GetClient().Endpoints.TvSeries.GetEpisodeGroupsAsync(seriesId);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetExternalIdsAsync()
    {
        int seriesId = Constants.TV_SERIES_ID;

        await ClientFactory.GetClient().Endpoints.TvSeries.GetExternalIdsAsync(seriesId);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetImagesAsync()
    {
        int seriesId = Constants.TV_SERIES_ID;
        string includeImageLanguage = null;
        string language = "en-US";

        await ClientFactory.GetClient().Endpoints.TvSeries.GetImagesAsync(seriesId, includeImageLanguage, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetKeywordsAsync()
    {
        int seriesId = Constants.TV_SERIES_ID;

        await ClientFactory.GetClient().Endpoints.TvSeries.GetKeywordsAsync(seriesId);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetLatestAsync()
    {
        await ClientFactory.GetClient().Endpoints.TvSeries.GetLatestAsync();
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetListsAsync()
    {
        int seriesId = Constants.TV_SERIES_ID;
        int page = 1;
        string language = "en-US";

        await ClientFactory.GetClient().Endpoints.TvSeries.GetListsAsync(seriesId, page, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetRecommendationsAsync()
    {
        int seriesId = Constants.TV_SERIES_ID;
        int page = 1;
        string language = "en-US";

        await ClientFactory.GetClient().Endpoints.TvSeries.GetRecommendationsAsync(seriesId, page, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetReviewsAsync()
    {
        int seriesId = Constants.TV_SERIES_ID;
        int page = 1;
        string language = "en-US";

        await ClientFactory.GetClient().Endpoints.TvSeries.GetReviewsAsync(seriesId, page, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetScreenedTheatricallyAsync()
    {
        int seriesId = Constants.TV_SERIES_ID;

        await ClientFactory.GetClient().Endpoints.TvSeries.GetScreenedTheatricallyAsync(seriesId);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetSimilarAsync()
    {
        int seriesId = Constants.TV_SERIES_ID;
        int page = 1;
        string language = "en-US";

        await ClientFactory.GetClient().Endpoints.TvSeries.GetSimilarAsync(seriesId, page, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetTranslationsAsync()
    {
        int seriesId = Constants.TV_SERIES_ID;

        await ClientFactory.GetClient().Endpoints.TvSeries.GetTranslationsAsync(seriesId);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetVideosAsync()
    {
        int seriesId = Constants.TV_SERIES_ID;
        string includeVideoLanguage = null;
        string language = "en-US";

        await ClientFactory.GetClient().Endpoints.TvSeries.GetVideosAsync(seriesId, includeVideoLanguage, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetWatchProvidersAsync()
    {
        int seriesId = Constants.TV_SERIES_ID;

        await ClientFactory.GetClient().Endpoints.TvSeries.GetWatchProvidersAsync(seriesId);
    }
}
