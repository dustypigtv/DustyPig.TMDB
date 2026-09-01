using DustyPig.TMDB.Models.TvSeasons;

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
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var item in ret.Data.Cast)
        {
            Assert.IsEmpty(item.AdditionalProperties);
            foreach (var item2 in item.Roles)
                Assert.IsEmpty(item2.AdditionalProperties);
        }
        foreach (var item in ret.Data.Crew)
        {
            Assert.IsEmpty(item.AdditionalProperties);
            foreach (var item2 in item.Jobs)
                Assert.IsEmpty(item2.AdditionalProperties);
        }
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
        int seasonNumber = 5;
        int seriesId = Constants.TV_SERIES_ID;
        string language = Constants.Language;

        var ret = await ClientFactory.GetClient().Endpoints.TvSeasons.GetCreditsAsync(seasonNumber, seriesId, language);
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

        var ret = await ClientFactory.GetClient().Endpoints.TvSeasons.GetDetailsAsync(seasonNumber, seriesId, appendToResponse, language);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        Assert.IsEmpty(ret.Data.AccountStates.AdditionalProperties);
        foreach (var item in ret.Data.AccountStates.Results)
            Assert.IsEmpty(item.AdditionalProperties);
        Assert.IsEmpty(ret.Data.AggregateCredits.AdditionalProperties);
        foreach (var item in ret.Data.AggregateCredits.Cast)
        {
            Assert.IsEmpty(item.AdditionalProperties);
            foreach (var item2 in item.Roles)
                Assert.IsEmpty(item2.AdditionalProperties);
        }
        foreach (var item in ret.Data.AggregateCredits.Crew)
        {
            Assert.IsEmpty(item.AdditionalProperties);
            foreach (var item2 in item.Jobs)
                Assert.IsEmpty(item2.AdditionalProperties);
        }
        Assert.IsEmpty(ret.Data.Credits.AdditionalProperties);
        foreach (var item in ret.Data.Credits.Cast)
            Assert.IsEmpty(item.AdditionalProperties);
        foreach (var item in ret.Data.Credits.Crew)
            Assert.IsEmpty(item.AdditionalProperties);
        foreach (var item in ret.Data.Episodes)
        {
            Assert.IsEmpty(item.AdditionalProperties);
            foreach (var item2 in item.Crew)
            {
                Assert.IsEmpty(item2.AdditionalProperties);
                foreach (var item3 in item2.Jobs)
                    Assert.IsEmpty(item3.AdditionalProperties);
            }
            foreach (var item2 in item.GuestStars)
                Assert.IsEmpty(item2.AdditionalProperties);
        }
        Assert.IsEmpty(ret.Data.ExternalIds.AdditionalProperties);
        Assert.IsEmpty(ret.Data.Images.AdditionalProperties);
        foreach (var item in ret.Data.Images.Posters)
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
        int seasonNumber = 5;
        int seriesId = Constants.TV_SERIES_ID;

        var ret = await ClientFactory.GetClient().Endpoints.TvSeasons.GetExternalIdsAsync(seasonNumber, seriesId);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
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
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var item in ret.Data.Posters)
            Assert.IsEmpty(item.AdditionalProperties);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetTranslations()
    {
        int seasonNumber = 5;
        int seriesId = Constants.TV_SERIES_ID;

        var ret = await ClientFactory.GetClient().Endpoints.TvSeasons.GetTranslationsAsync(seasonNumber, seriesId);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var item in ret.Data.Translations)
            Assert.IsEmpty(item.AdditionalProperties);
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
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var item in ret.Data.Results)
            Assert.IsEmpty(item.AdditionalProperties);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetWatchProviders()
    {
        int seasonNumber = 5;
        int seriesId = Constants.TV_SERIES_ID;
        string language = Constants.Language;

        var ret = await ClientFactory.GetClient().Endpoints.TvSeasons.GetWatchProvidersAsync(seasonNumber, seriesId, language);
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
