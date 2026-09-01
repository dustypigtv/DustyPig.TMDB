using DustyPig.TMDB.Enums;

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

        var ret = await ClientFactory.GetClient().Endpoints.TvSeasons.GetAggregateCreditsAsync(seasonNumber, seriesId, language);
        AdditionalPropertiesChecker.Check(ret);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetChanges()
    {
        int seasonId = 59469;
        int page = 1;
        DateOnly? endDate = null;
        DateOnly? startDate = null;

        var ret = await ClientFactory.GetClient().Endpoints.TvSeasons.GetChangesAsync(seasonId, page, endDate, startDate);
        AdditionalPropertiesChecker.Check(ret);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetCredits()
    {
        int seasonNumber = 5;
        int seriesId = Constants.TV_SERIES_ID;
        string language = Constants.Language;

        var ret = await ClientFactory.GetClient().Endpoints.TvSeasons.GetCreditsAsync(seasonNumber, seriesId, language);
        AdditionalPropertiesChecker.Check(ret);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetDetails()
    {
        int seasonNumber = 5;
        int seriesId = Constants.TV_SERIES_ID;
        TvSeasonAppendToResponse? appendToResponse =
            TvSeasonAppendToResponse.AccountStates |
            TvSeasonAppendToResponse.AggregateCredits |
            TvSeasonAppendToResponse.Credits |
            TvSeasonAppendToResponse.ExternalIds |
            TvSeasonAppendToResponse.Images |
            TvSeasonAppendToResponse.Translations |
            TvSeasonAppendToResponse.Videos;
        string language = Constants.Language;

        var ret = await ClientFactory.GetClient().Endpoints.TvSeasons.GetDetailsAsync(seasonNumber, seriesId, appendToResponse, language);
        AdditionalPropertiesChecker.Check(ret);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetExternalIds()
    {
        int seasonNumber = 5;
        int seriesId = Constants.TV_SERIES_ID;

        var ret = await ClientFactory.GetClient().Endpoints.TvSeasons.GetExternalIdsAsync(seasonNumber, seriesId);
        AdditionalPropertiesChecker.Check(ret);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetImages()
    {
        int seasonNumber = 5;
        int seriesId = Constants.TV_SERIES_ID;
        string includeImageLanguage = null;
        string language = Constants.Language;

        var ret = await ClientFactory.GetClient().Endpoints.TvSeasons.GetImagesAsync(seasonNumber, seriesId, includeImageLanguage, language);
        AdditionalPropertiesChecker.Check(ret);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetTranslations()
    {
        int seasonNumber = 5;
        int seriesId = Constants.TV_SERIES_ID;

        var ret = await ClientFactory.GetClient().Endpoints.TvSeasons.GetTranslationsAsync(seasonNumber, seriesId);
        AdditionalPropertiesChecker.Check(ret);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetVideos()
    {
        int seasonNumber = 5;
        int seriesId = Constants.TV_SERIES_ID;
        string includeVideoLanguage = null;
        string language = Constants.Language;

        var ret = await ClientFactory.GetClient().Endpoints.TvSeasons.GetVideosAsync(seasonNumber, seriesId, includeVideoLanguage, language);
        AdditionalPropertiesChecker.Check(ret);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetWatchProviders()
    {
        int seasonNumber = 5;
        int seriesId = Constants.TV_SERIES_ID;
        string language = Constants.Language;

        var ret = await ClientFactory.GetClient().Endpoints.TvSeasons.GetWatchProvidersAsync(seasonNumber, seriesId, language);
        AdditionalPropertiesChecker.Check(ret);
    }
}
