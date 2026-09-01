using DustyPig.TMDB.Models.People;

namespace TestsProject.UnAuthentactedTests;

[TestClass]
public class TestPeopleMethods
{
    [TestMethod]
    [DoNotParallelize]
    public async Task GetChanges()
    {
        int personId = Constants.PERSON_ID;
        int page = 1;
        DateOnly? endDate = null;
        DateOnly? startDate = null;

        var ret = await ClientFactory.GetClient().Endpoints.People.GetChangesAsync(personId, page, endDate, startDate);
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
    public async Task GetCombinedCredits()
    {
        int personId = Constants.PERSON_ID;
        string language = Constants.Language;

        var ret = await ClientFactory.GetClient().Endpoints.People.GetCombinedCreditsAsync(personId, language);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var item in ret.Data.Crew)
            Assert.IsEmpty(item.AdditionalProperties);
        foreach (var item in ret.Data.Cast)
            Assert.IsEmpty(item.AdditionalProperties);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetDetails()
    {
        int personId = Constants.PERSON_ID;
        AppendToResponse? appendToResponse =
            AppendToResponse.Changes |
            AppendToResponse.CombinedCredits |
            AppendToResponse.ExternalIds |
            AppendToResponse.Images |
            AppendToResponse.MovieCredits |
            AppendToResponse.Translations |
            AppendToResponse.TvCredits;

        string language = Constants.Language;

        var ret = await ClientFactory.GetClient().Endpoints.People.GetDetailsAsync(personId, appendToResponse, language);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        Assert.IsEmpty(ret.Data.Changes.AdditionalProperties);
        foreach (var item in ret.Data.Changes.Changes)
        {
            Assert.IsEmpty(item.AdditionalProperties);
            foreach (var item2 in item.Items)
                Assert.IsEmpty(item2.AdditionalProperties);
        }
        Assert.IsEmpty(ret.Data.CombinedCredits.AdditionalProperties);
        foreach (var item in ret.Data.CombinedCredits.Cast)
            Assert.IsEmpty(item.AdditionalProperties);
        foreach (var item in ret.Data.CombinedCredits.Crew)
            Assert.IsEmpty(item.AdditionalProperties);
        Assert.IsEmpty(ret.Data.ExternalIds.AdditionalProperties);
        Assert.IsEmpty(ret.Data.Images.AdditionalProperties);
        foreach (var item in ret.Data.Images.Profiles)
            Assert.IsEmpty(item.AdditionalProperties);
        Assert.IsEmpty(ret.Data.MovieCredits.AdditionalProperties);
        foreach (var item in ret.Data.MovieCredits.Cast)
            Assert.IsEmpty(item.AdditionalProperties);
        foreach (var item in ret.Data.MovieCredits.Crew)
            Assert.IsEmpty(item.AdditionalProperties);
        Assert.IsEmpty(ret.Data.Translations.AdditionalProperties);
        foreach (var item in ret.Data.Translations.Translations)
        {
            Assert.IsEmpty(item.AdditionalProperties);
            Assert.IsEmpty(item.Data.AdditionalProperties);
        }
        Assert.IsEmpty(ret.Data.TvCredits.AdditionalProperties);
        foreach (var item in ret.Data.TvCredits.Cast)
            Assert.IsEmpty(item.AdditionalProperties);
        foreach (var item in ret.Data.TvCredits.Crew)
            Assert.IsEmpty(item.AdditionalProperties);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetExternalIds()
    {
        int personId = Constants.PERSON_ID;

        var ret = await ClientFactory.GetClient().Endpoints.People.GetExternalIdsAsync(personId);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetImages()
    {
        int personId = Constants.PERSON_ID;

        var ret = await ClientFactory.GetClient().Endpoints.People.GetImagesAsync(personId);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var item in ret.Data.Profiles)
            Assert.IsEmpty(item.AdditionalProperties);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetLatest()
    {
        var ret = await ClientFactory.GetClient().Endpoints.People.GetLatestAsync();
        Assert.IsEmpty(ret.Data.AdditionalProperties);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetMovieCredits()
    {
        int personId = Constants.PERSON_ID;
        string language = Constants.Language;

        var ret = await ClientFactory.GetClient().Endpoints.People.GetMovieCreditsAsync(personId, language);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var item in ret.Data.Cast)
            Assert.IsEmpty(item.AdditionalProperties);
        foreach (var item in ret.Data.Crew)
            Assert.IsEmpty(item.AdditionalProperties);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetTranslations()
    {
        int personId = Constants.PERSON_ID;

        var ret = await ClientFactory.GetClient().Endpoints.People.GetTranslationsAsync(personId);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var item in ret.Data.Translations)
            Assert.IsEmpty(item.AdditionalProperties);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetTvSeriesCredits()
    {
        int personId = Constants.PERSON_ID;
        string language = Constants.Language;

        var ret = await ClientFactory.GetClient().Endpoints.People.GetTvSeriesCreditsAsync(personId, language);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var item in ret.Data.Cast)
            Assert.IsEmpty(item.AdditionalProperties);
        foreach (var item in ret.Data.Crew)
            Assert.IsEmpty(item.AdditionalProperties);
    }
}
