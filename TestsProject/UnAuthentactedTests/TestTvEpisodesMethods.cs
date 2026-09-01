using DustyPig.TMDB.Models.TvEpisodes;

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
        int episodeNumber = 1;
        int seasonNumber = 5;
        int seriesId = Constants.TV_SERIES_ID;
        string language = Constants.Language;

        var ret = await ClientFactory.GetClient().Endpoints.TvEpisodes.GetCreditsAsync(episodeNumber, seasonNumber, seriesId, language);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var item in ret.Data.Cast)
            Assert.IsEmpty(item.AdditionalProperties);
        foreach (var item in ret.Data.Crew)
            Assert.IsEmpty(item.AdditionalProperties);
        foreach (var item in ret.Data.GuestStars)
            Assert.IsEmpty(item.AdditionalProperties);
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

        var ret = await ClientFactory.GetClient().Endpoints.TvEpisodes.GetDetailsAsync(episodeNumber, seasonNumber, seriesId, appendToResponse, language);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        //Assert.IsEmpty(ret.Data.AccountStates.AdditionalProperties);
        Assert.IsEmpty(ret.Data.Credits.AdditionalProperties);
        foreach (var item in ret.Data.Credits.Cast)
            Assert.IsEmpty(item.AdditionalProperties);
        foreach (var item in ret.Data.Credits.Crew)
            Assert.IsEmpty(item.AdditionalProperties);
        foreach (var item in ret.Data.Credits.GuestStars)
            Assert.IsEmpty(item.AdditionalProperties);
        foreach (var item in ret.Data.Crew)
            Assert.IsEmpty(item.AdditionalProperties);
        Assert.IsEmpty(ret.Data.ExternalIds.AdditionalProperties);
        foreach (var item in ret.Data.GuestStars)
            Assert.IsEmpty(item.AdditionalProperties);
        Assert.IsEmpty(ret.Data.Images.AdditionalProperties);
        foreach (var item in ret.Data.Images.Stills)
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
        int episodeNumber = 1;
        int seasonNumber = 5;
        int seriesId = Constants.TV_SERIES_ID;

        var ret = await ClientFactory.GetClient().Endpoints.TvEpisodes.GetExternalIdsAsync(episodeNumber, seasonNumber, seriesId);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
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
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var item in ret.Data.Stills)
            Assert.IsEmpty(item.AdditionalProperties);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetTranslations()
    {
        int episodeNumber = 1;
        int seasonNumber = 5;
        int seriesId = Constants.TV_SERIES_ID;

        var ret = await ClientFactory.GetClient().Endpoints.TvEpisodes.GetTranslationsAsync(episodeNumber, seasonNumber, seriesId);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var item in ret.Data.Translations)
            Assert.IsEmpty(item.AdditionalProperties);
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
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var item in ret.Data.Results)
            Assert.IsEmpty(item.AdditionalProperties);
    }
}
