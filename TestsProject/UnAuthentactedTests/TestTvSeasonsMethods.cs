using DustyPig.TMDB.Models.TvSeasons;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsProject.UnAuthentactedTests;

[TestClass]
public class TestTvSeasonsMethods
{
    [TestMethod]
    [DoNotParallelize]
    public async Task GetAggregateCredits()
    {
        int seasonNumber = 5;
        int seriesId = Constants.TV_SERIES_ID;
        string language = Constants.Language;

        await ClientFactory.GetClient().Endpoints.TvSeasons.GetAggregateCreditsAsync(seasonNumber, seriesId, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetChanges()
    {
        int seasonId = 59469;
        int page = 1;
        DateOnly? endDate = null;
        DateOnly? startDate = null;

        await ClientFactory.GetClient().Endpoints.TvSeasons.GetChangesAsync(seasonId, page, endDate, startDate);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetCredits()
    {
        int seasonNumber = 5;
        int seriesId = Constants.TV_SERIES_ID;
        string language = Constants.Language;

        await ClientFactory.GetClient().Endpoints.TvSeasons.GetCreditsAsync(seasonNumber, seriesId, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetDetails()
    {
        int seasonNumber = 5;
        int seriesId = Constants.TV_SERIES_ID;
        AppendToResponse? appendToResponse =
            AppendToResponse.AggregateCredits |
            AppendToResponse.Credits |
            AppendToResponse.ExternalIds |
            AppendToResponse.Images |
            AppendToResponse.Translations |
            AppendToResponse.Videos;
        string language = Constants.Language;

        await ClientFactory.GetClient().Endpoints.TvSeasons.GetDetailsAsync(seasonNumber, seriesId, appendToResponse, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetExternalIds()
    {
        int seasonNumber = 5;
        int seriesId = Constants.TV_SERIES_ID;

        await ClientFactory.GetClient().Endpoints.TvSeasons.GetExternalIdsAsync(seasonNumber, seriesId);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetImages()
    {
        int seasonNumber = 5;
        int seriesId = Constants.TV_SERIES_ID;
        string includeImageLanguage = null;
        string language = Constants.Language;

        await ClientFactory.GetClient().Endpoints.TvSeasons.GetImagesAsync(seasonNumber, seriesId, includeImageLanguage, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetTranslations()
    {
        int seasonNumber = 5;
        int seriesId = Constants.TV_SERIES_ID;

        await ClientFactory.GetClient().Endpoints.TvSeasons.GetTranslationsAsync(seasonNumber, seriesId);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetVideos()
    {
        int seasonNumber = 5;
        int seriesId = Constants.TV_SERIES_ID;
        string includeVideoLanguage = null;
        string language = Constants.Language;

        await ClientFactory.GetClient().Endpoints.TvSeasons.GetVideosAsync(seasonNumber, seriesId, includeVideoLanguage, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetWatchProviders()
    {
        int seasonNumber = 5;
        int seriesId = Constants.TV_SERIES_ID;
        string language = Constants.Language;

        await ClientFactory.GetClient().Endpoints.TvSeasons.GetWatchProvidersAsync(seasonNumber, seriesId, language);
    }
}
