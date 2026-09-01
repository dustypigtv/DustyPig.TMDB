using DustyPig.TMDB.Enums;

namespace TestsProject.UnAuthentactedTests;

[TestClass]
public class TestTvEpisodesMethods
{
    [TestMethod]
    [DoNotParallelize]
    public async Task GetChanges()
    {
        int episodeId = 949491;

        var ret = await ClientFactory.GetClient().Endpoints.TvEpisodes.GetChangesAsync(episodeId);
        AdditionalPropertiesChecker.Check(ret);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetCredits()
    {
        int episodeNumber = 1;
        int seasonNumber = 5;
        int seriesId = Constants.TV_SERIES_ID;
        string language = Constants.Language;

        var ret = await ClientFactory.GetClient().Endpoints.TvEpisodes.GetCreditsAsync(episodeNumber, seasonNumber, seriesId, language);
        AdditionalPropertiesChecker.Check(ret);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetDetails()
    {
        int episodeNumber = 1;
        int seasonNumber = 5;
        int seriesId = Constants.TV_SERIES_ID;
        TvEpisodeAppendToResponse? appendToResponse =
            TvEpisodeAppendToResponse.AccountStates |
            TvEpisodeAppendToResponse.Credits |
            TvEpisodeAppendToResponse.ExternalIds |
            TvEpisodeAppendToResponse.Images |
            TvEpisodeAppendToResponse.Translations |
            TvEpisodeAppendToResponse.Videos;
        string language = Constants.Language;

        var ret = await ClientFactory.GetClient().Endpoints.TvEpisodes.GetDetailsAsync(episodeNumber, seasonNumber, seriesId, appendToResponse, language);
        AdditionalPropertiesChecker.Check(ret);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetExternalIds()
    {
        int episodeNumber = 1;
        int seasonNumber = 5;
        int seriesId = Constants.TV_SERIES_ID;

        var ret = await ClientFactory.GetClient().Endpoints.TvEpisodes.GetExternalIdsAsync(episodeNumber, seasonNumber, seriesId);
        AdditionalPropertiesChecker.Check(ret);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetImages()
    {
        int episodeNumber = 1;
        int seasonNumber = 5;
        int seriesId = Constants.TV_SERIES_ID;
        string includeImageLanguage = null;
        string language = Constants.Language;

        var ret = await ClientFactory.GetClient().Endpoints.TvEpisodes.GetImagesAsync(episodeNumber, seasonNumber, seriesId, includeImageLanguage, language);
        AdditionalPropertiesChecker.Check(ret);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetTranslations()
    {
        int episodeNumber = 1;
        int seasonNumber = 5;
        int seriesId = Constants.TV_SERIES_ID;

        var ret = await ClientFactory.GetClient().Endpoints.TvEpisodes.GetTranslationsAsync(episodeNumber, seasonNumber, seriesId);
        AdditionalPropertiesChecker.Check(ret);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetVideos()
    {
        int episodeNumber = 1;
        int seasonNumber = 5;
        int seriesId = Constants.TV_SERIES_ID;
        string includeVideoLanguage = null;
        string language = Constants.Language;

        var ret = await ClientFactory.GetClient().Endpoints.TvEpisodes.GetVideosAsync(episodeNumber, seasonNumber, seriesId, includeVideoLanguage, language);
        AdditionalPropertiesChecker.Check(ret);
    }
}
