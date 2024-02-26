using DustyPig.TMDB.Models.People;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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

        await ClientFactory.GetClient().Endpoints.People.GetChangesAsync(personId, page, endDate, startDate);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetCombinedCredits()
    {
        int personId = Constants.PERSON_ID;
        string language = Constants.Language;

        await ClientFactory.GetClient().Endpoints.People.GetCombinedCreditsAsync(personId, language);
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

        await ClientFactory.GetClient().Endpoints.People.GetDetailsAsync(personId, appendToResponse, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetExternalIds()
    {
        int personId = Constants.PERSON_ID;

        await ClientFactory.GetClient().Endpoints.People.GetExternalIdsAsync(personId);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetImages()
    {
        int personId = Constants.PERSON_ID;

        await ClientFactory.GetClient().Endpoints.People.GetImagesAsync(personId);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetLatest()
    {
        await ClientFactory.GetClient().Endpoints.People.GetLatestAsync();
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetMovieCredits()
    {
        int personId = Constants.PERSON_ID;
        string language = Constants.Language;

        await ClientFactory.GetClient().Endpoints.People.GetMovieCreditsAsync(personId, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetTranslations()
    {
        int personId = Constants.PERSON_ID;

        await ClientFactory.GetClient().Endpoints.People.GetTranslationsAsync(personId);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetTvCredits()
    {
        int personId = Constants.PERSON_ID;
        string language = Constants.Language;

        await ClientFactory.GetClient().Endpoints.People.GetTvCreditsAsync(personId, language);
    }
}
