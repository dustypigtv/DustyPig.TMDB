using DustyPig.TMDB.Models.TvSeries;

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

        var ret = await ClientFactory.GetClient().Endpoints.TvSeries.GetAggregateCreditsAsync(seriesId, language);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var item in ret.Data.Cast)
        {
            Assert.IsEmpty(item.AdditionalProperties);
            foreach (var item2 in item.Roles)
                Assert.IsEmpty(item2.AdditionalProperties);
        }
        foreach (var item in ret.Data.Crew)
            Assert.IsEmpty(item.AdditionalProperties);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetAlternativeTitles()
    {
        int seriesId = Constants.TV_SERIES_ID;

        var ret = await ClientFactory.GetClient().Endpoints.TvSeries.GetAlternativeTitlesAsync(seriesId);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var item in ret.Data.Results)
            Assert.IsEmpty(item.AdditionalProperties);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetChanges()
    {
        int seriesId = Constants.TV_SERIES_ID;
        int page = 1;
        DateOnly? endDate = null;
        DateOnly? startDate = null;

        var ret = await ClientFactory.GetClient().Endpoints.TvSeries.GetChangesAsync(seriesId, page, endDate, startDate);
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
    public async Task GetContentRatings()
    {
        int seriesId = Constants.TV_SERIES_ID;

        var ret = await ClientFactory.GetClient().Endpoints.TvSeries.GetContentRatingsAsync(seriesId);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var item in ret.Data.Results)
            Assert.IsEmpty(item.AdditionalProperties);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetCredits()
    {
        int seriesId = Constants.TV_SERIES_ID;
        string language = Constants.Language;

        var ret = await ClientFactory.GetClient().Endpoints.TvSeries.GetCreditsAsync(seriesId, language);
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

        var ret = await ClientFactory.GetClient().Endpoints.TvSeries.GetDetailsAsync(seriesId, appendToResponse, language);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        Assert.IsEmpty(ret.Data.AccountStates.AdditionalProperties);
        Assert.IsEmpty(ret.Data.AggregateCredits.AdditionalProperties);
        foreach (var item in ret.Data.AggregateCredits.Cast)
        {
            Assert.IsEmpty(item.AdditionalProperties);
            foreach (var item2 in item.Roles)
                Assert.IsEmpty(item2.AdditionalProperties);
        }
        foreach (var item in ret.Data.AggregateCredits.Crew)
            Assert.IsEmpty(item.AdditionalProperties);
        Assert.IsEmpty(ret.Data.AlternativeTitles.AdditionalProperties);
        foreach (var item in ret.Data.AlternativeTitles.Results)
            Assert.IsEmpty(item.AdditionalProperties);
        Assert.IsEmpty(ret.Data.Changes.AdditionalProperties);
        foreach (var item in ret.Data.Changes.Changes)
        {
            Assert.IsEmpty(item.AdditionalProperties);
            foreach (var item2 in item.Items)
                Assert.IsEmpty(item2.AdditionalProperties);
        }
        Assert.IsEmpty(ret.Data.ContentRatings.AdditionalProperties);
        foreach (var item in ret.Data.ContentRatings.Results)
            Assert.IsEmpty(item.AdditionalProperties);
        foreach (var item in ret.Data.CreatedBy)
            Assert.IsEmpty(item.AdditionalProperties);
        Assert.IsEmpty(ret.Data.Credits.AdditionalProperties);
        foreach (var item in ret.Data.Credits.Crew)
            Assert.IsEmpty(item.AdditionalProperties);
        foreach (var item in ret.Data.Credits.Cast)
            Assert.IsEmpty(item.AdditionalProperties);
        Assert.IsEmpty(ret.Data.EpisodeGroups.AdditionalProperties);
        foreach (var item in ret.Data.EpisodeGroups.Results)
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
        foreach (var item in ret.Data.Keywords.Results)
            Assert.IsEmpty(item.AdditionalProperties);
        Assert.IsEmpty(ret.Data.Lists.AdditionalProperties);
        foreach (var item in ret.Data.Lists.Results)
            Assert.IsEmpty(item.AdditionalProperties);
        foreach (var item in ret.Data.Networks)
            Assert.IsEmpty(item.AdditionalProperties);
        foreach (var item in ret.Data.ProductionCompanies)
            Assert.IsEmpty(item.AdditionalProperties);
        foreach (var item in ret.Data.ProductionCountries)
            Assert.IsEmpty(item.AdditionalProperties);
        Assert.IsEmpty(ret.Data.Recommendations.AdditionalProperties);
        foreach (var item in ret.Data.Recommendations.Results)
            Assert.IsEmpty(item.AdditionalProperties);
        Assert.IsEmpty(ret.Data.Reviews.AdditionalProperties);
        foreach (var item in ret.Data.Reviews.Results)
        {
            Assert.IsEmpty(item.AdditionalProperties);
            Assert.IsEmpty(item.AuthorDetails.AdditionalProperties);
        }
        Assert.IsEmpty(ret.Data.ScreenedTheatrically.AdditionalProperties);
        foreach (var item in ret.Data.ScreenedTheatrically.Results)
            Assert.IsEmpty(item.AdditionalProperties);
        foreach (var item in ret.Data.Seasons)
            Assert.IsEmpty(item.AdditionalProperties);
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
    public async Task GetEpisodeGroups()
    {
        int seriesId = Constants.TV_SERIES_ID;

        var ret = await ClientFactory.GetClient().Endpoints.TvSeries.GetEpisodeGroupsAsync(seriesId);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var item in ret.Data.Results)
            Assert.IsEmpty(item.AdditionalProperties);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetExternalIds()
    {
        int seriesId = Constants.TV_SERIES_ID;

        var ret = await ClientFactory.GetClient().Endpoints.TvSeries.GetExternalIdsAsync(seriesId);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetImages()
    {
        int seriesId = Constants.TV_SERIES_ID;
        string includeImageLanguage = null;
        string language = Constants.Language;

        var ret = await ClientFactory.GetClient().Endpoints.TvSeries.GetImagesAsync(seriesId, includeImageLanguage, language);
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
        int seriesId = Constants.TV_SERIES_ID;

        var ret = await ClientFactory.GetClient().Endpoints.TvSeries.GetKeywordsAsync(seriesId);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var item in ret.Data.Results)
            Assert.IsEmpty(item.AdditionalProperties);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetLatest()
    {
        var ret = await ClientFactory.GetClient().Endpoints.TvSeries.GetLatestAsync();
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var item in ret.Data.Seasons)
            Assert.IsEmpty(item.AdditionalProperties);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetLists()
    {
        int seriesId = Constants.TV_SERIES_ID;
        int page = 1;
        string language = Constants.Language;

        var ret = await ClientFactory.GetClient().Endpoints.TvSeries.GetListsAsync(seriesId, page, language);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var item in ret.Data.Results)
            Assert.IsEmpty(item.AdditionalProperties);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetRecommendations()
    {
        int seriesId = Constants.TV_SERIES_ID;
        int page = 1;
        string language = Constants.Language;

        var ret = await ClientFactory.GetClient().Endpoints.TvSeries.GetRecommendationsAsync(seriesId, page, language);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var item in ret.Data.Results)
            Assert.IsEmpty(item.AdditionalProperties);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetReviews()
    {
        int seriesId = Constants.TV_SERIES_ID;
        int page = 1;
        string language = Constants.Language;

        var ret = await ClientFactory.GetClient().Endpoints.TvSeries.GetReviewsAsync(seriesId, page, language);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var item in ret.Data.Results)
        {
            Assert.IsEmpty(item.AdditionalProperties);
            Assert.IsEmpty(item.AuthorDetails.AdditionalProperties);
        }
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetScreenedTheatrically()
    {
        int seriesId = Constants.TV_SERIES_ID;

        var ret = await ClientFactory.GetClient().Endpoints.TvSeries.GetScreenedTheatricallyAsync(seriesId);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var item in ret.Data.Results)
            Assert.IsEmpty(item.AdditionalProperties);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetSimilar()
    {
        int seriesId = Constants.TV_SERIES_ID;
        int page = 1;
        string language = Constants.Language;

        var ret = await ClientFactory.GetClient().Endpoints.TvSeries.GetSimilarAsync(seriesId, page, language);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var item in ret.Data.Results)
            Assert.IsEmpty(item.AdditionalProperties);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetTranslations()
    {
        int seriesId = Constants.TV_SERIES_ID;

        var ret = await ClientFactory.GetClient().Endpoints.TvSeries.GetTranslationsAsync(seriesId);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var item in ret.Data.Translations)
            Assert.IsEmpty(item.AdditionalProperties);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetVideos()
    {
        int seriesId = Constants.TV_SERIES_ID;
        string includeVideoLanguage = null;
        string language = Constants.Language;

        var ret = await ClientFactory.GetClient().Endpoints.TvSeries.GetVideosAsync(seriesId, includeVideoLanguage, language);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var item in ret.Data.Results)
            Assert.IsEmpty(item.AdditionalProperties);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetWatchProviders()
    {
        int seriesId = Constants.TV_SERIES_ID;

        var ret = await ClientFactory.GetClient().Endpoints.TvSeries.GetWatchProvidersAsync(seriesId);
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
