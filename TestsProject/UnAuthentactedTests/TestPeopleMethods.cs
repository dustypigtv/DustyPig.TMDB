using DustyPig.TMDB.Enums;

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
        AdditionalPropertiesChecker.Check(ret);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetCombinedCredits()
    {
        int personId = Constants.PERSON_ID;
        string language = Constants.Language;

        var ret = await ClientFactory.GetClient().Endpoints.People.GetCombinedCreditsAsync(personId, language);
        AdditionalPropertiesChecker.Check(ret);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetDetails()
    {
        int personId = Constants.PERSON_ID;
        PersonAppendToResponse? appendToResponse =
            PersonAppendToResponse.Changes |
            PersonAppendToResponse.CombinedCredits |
            PersonAppendToResponse.ExternalIds |
            PersonAppendToResponse.Images |
            PersonAppendToResponse.MovieCredits |
            PersonAppendToResponse.Translations |
            PersonAppendToResponse.TvCredits;

        string language = Constants.Language;

        var ret = await ClientFactory.GetClient().Endpoints.People.GetDetailsAsync(personId, appendToResponse, language);
        AdditionalPropertiesChecker.Check(ret);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetExternalIds()
    {
        int personId = Constants.PERSON_ID;

        var ret = await ClientFactory.GetClient().Endpoints.People.GetExternalIdsAsync(personId);
        AdditionalPropertiesChecker.Check(ret);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetImages()
    {
        int personId = Constants.PERSON_ID;

        var ret = await ClientFactory.GetClient().Endpoints.People.GetImagesAsync(personId);
        AdditionalPropertiesChecker.Check(ret);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetLatest()
    {
        var ret = await ClientFactory.GetClient().Endpoints.People.GetLatestAsync();
        AdditionalPropertiesChecker.Check(ret);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetMovieCredits()
    {
        int personId = Constants.PERSON_ID;
        string language = Constants.Language;

        var ret = await ClientFactory.GetClient().Endpoints.People.GetMovieCreditsAsync(personId, language);
        AdditionalPropertiesChecker.Check(ret);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetTranslations()
    {
        int personId = Constants.PERSON_ID;

        var ret = await ClientFactory.GetClient().Endpoints.People.GetTranslationsAsync(personId);
        AdditionalPropertiesChecker.Check(ret);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetTvSeriesCredits()
    {
        int personId = Constants.PERSON_ID;
        string language = Constants.Language;

        var ret = await ClientFactory.GetClient().Endpoints.People.GetTvSeriesCreditsAsync(personId, language);
        AdditionalPropertiesChecker.Check(ret);
    }
}
