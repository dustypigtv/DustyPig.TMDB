using DustyPig.TMDB.Models.TvEpisodes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsProject.UnAuthentactedTests;

[TestClass]
public class TestTvEpisodesMethods
{
    [TestMethod]
    [DoNotParallelize]
    public async Task GetChanges()
    {
        int episodeId = 949491;

        await ClientFactory.GetClient().Endpoints.TvEpisodes.GetChangesAsync(episodeId);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetCredits()
    {
        int episodeNumber = 1;
        int seasonNumber = 5;
        int seriesId = Constants.TV_SERIES_ID;
        string language = Constants.Language;

        await ClientFactory.GetClient().Endpoints.TvEpisodes.GetCreditsAsync(episodeNumber, seasonNumber, seriesId, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetDetails()
    {
        int episodeNumber = 1;
        int seasonNumber = 5;
        int seriesId = Constants.TV_SERIES_ID;
        AppendToResponse? appendToResponse =
            AppendToResponse.AccountStates |
            AppendToResponse.Credits |
            AppendToResponse.ExternalIds |
            AppendToResponse.Images |
            AppendToResponse.Translations |
            AppendToResponse.Videos;
        string language = Constants.Language;

        await ClientFactory.GetClient().Endpoints.TvEpisodes.GetDetailsAsync(episodeNumber, seasonNumber, seriesId, appendToResponse, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetExternalIds()
    {
        int episodeNumber = 1;
        int seasonNumber = 5;
        int seriesId = Constants.TV_SERIES_ID;

        await ClientFactory.GetClient().Endpoints.TvEpisodes.GetExternalIdsAsync(episodeNumber, seasonNumber, seriesId);
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

        await ClientFactory.GetClient().Endpoints.TvEpisodes.GetImagesAsync(episodeNumber, seasonNumber, seriesId, includeImageLanguage, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetTranslations()
    {
        int episodeNumber = 1;
        int seasonNumber = 5;
        int seriesId = Constants.TV_SERIES_ID;

        await ClientFactory.GetClient().Endpoints.TvEpisodes.GetTranslationsAsync(episodeNumber, seasonNumber, seriesId);
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

        await ClientFactory.GetClient().Endpoints.TvEpisodes.GetVideosAsync(episodeNumber, seasonNumber, seriesId, includeVideoLanguage, language);
    }
}
