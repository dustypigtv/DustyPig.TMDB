using DustyPig.TMDB.Models.TvSeasons;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsProject;

[TestClass]
public class TestTvSeasonsMethods
{
    //[TestMethod]
    [DoNotParallelize]
    public async Task GetAccountStatesAsync()
    {
        int seasonNumber = 5;
        int seriesId = Constants.TV_SERIES_ID;
        string guestSessionId = null;
        string sessionId = null;

        await ClientFactory.GetClient().Endpoints.TvSeasons.GetAccountStatesAsync(seasonNumber, seriesId, guestSessionId, sessionId);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetAggregateCreditsAsync()
    {
        int seasonNumber = 5;
        int seriesId = Constants.TV_SERIES_ID;
        string language = "en-US";

        await ClientFactory.GetClient().Endpoints.TvSeasons.GetAggregateCreditsAsync(seasonNumber, seriesId, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetChangesAsync()
    {
        //int seasonId = 5;
        int page = 1;
        DateOnly? endDate = null;
        DateOnly? startDate = null;

        //await ClientFactory.GetClient().Endpoints.TvSeasons.GetChangesAsync(seasonId, page, endDate, startDate);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetCreditsAsync()
    {
        int seasonNumber = 5;
        int seriesId = Constants.TV_SERIES_ID;
        string language = "en-US";

        await ClientFactory.GetClient().Endpoints.TvSeasons.GetCreditsAsync(seasonNumber, seriesId, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetDetailsAsync()
    {
        int seasonNumber = 5;
        int seriesId = Constants.TV_SERIES_ID;
        AppendToResponse? appendToResponse = null;
        string language = "en-US";

        await ClientFactory.GetClient().Endpoints.TvSeasons.GetDetailsAsync(seasonNumber, seriesId, appendToResponse, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetExternalIdsAsync()
    {
        int seasonNumber = 5;
        int seriesId = Constants.TV_SERIES_ID;

        await ClientFactory.GetClient().Endpoints.TvSeasons.GetExternalIdsAsync(seasonNumber, seriesId);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetImagesAsync()
    {
        int seasonNumber = 5;
        int seriesId = Constants.TV_SERIES_ID;
        string includeImageLanguage = null;
        string language = "en-US";

        await ClientFactory.GetClient().Endpoints.TvSeasons.GetImagesAsync(seasonNumber, seriesId, includeImageLanguage, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetTranslationsAsync()
    {
        int seasonNumber = 5;
        int seriesId = Constants.TV_SERIES_ID;

        await ClientFactory.GetClient().Endpoints.TvSeasons.GetTranslationsAsync(seasonNumber, seriesId);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetVideosAsync()
    {
        int seasonNumber = 5;
        int seriesId = Constants.TV_SERIES_ID;
        string includeVideoLanguage = null;
        string language = "en-US";

        await ClientFactory.GetClient().Endpoints.TvSeasons.GetVideosAsync(seasonNumber, seriesId, includeVideoLanguage, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetWatchProvidersAsync()
    {
        int seasonNumber = 5;
        int seriesId = Constants.TV_SERIES_ID;
        string language = "en-US";

        await ClientFactory.GetClient().Endpoints.TvSeasons.GetWatchProvidersAsync(seasonNumber, seriesId, language);
    }
}
