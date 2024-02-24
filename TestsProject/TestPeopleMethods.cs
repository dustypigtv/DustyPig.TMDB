using DustyPig.TMDB.Models.People;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsProject;

[TestClass]
public class TestPeopleMethods
{
    [TestMethod]
    [DoNotParallelize]
    public async Task GetChangesAsync()
    {
        //int personId = ;
        int page = 1;
        DateOnly? endDate = null;
        DateOnly? startDate = null;

        //await ClientFactory.GetClient().Endpoints.People.GetChangesAsync(personId, page, endDate, startDate);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetCombinedCreditsAsync()
    {
        //string personId = ;
        string language = "en-US";

        //await ClientFactory.GetClient().Endpoints.People.GetCombinedCreditsAsync(personId, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetDetailsAsync()
    {
        //int personId = ;
        AppendToResponse? appendToResponse = null;
        string language = "en-US";

        //await ClientFactory.GetClient().Endpoints.People.GetDetailsAsync(personId, appendToResponse, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetExternalIdsAsync()
    {
        //int personId = ;

        //await ClientFactory.GetClient().Endpoints.People.GetExternalIdsAsync(personId);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetImagesAsync()
    {
        //int personId = ;

        //await ClientFactory.GetClient().Endpoints.People.GetImagesAsync(personId);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetLatestAsync()
    {
        await ClientFactory.GetClient().Endpoints.People.GetLatestAsync();
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetMovieCreditsAsync()
    {
        //int personId = ;
        string language = "en-US";

        //await ClientFactory.GetClient().Endpoints.People.GetMovieCreditsAsync(personId, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetTranslationsAsync()
    {
        //int personId = ;

        //await ClientFactory.GetClient().Endpoints.People.GetTranslationsAsync(personId);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetTvCreditsAsync()
    {
        //int personId = ;
        string language = "en-US";

        //await ClientFactory.GetClient().Endpoints.People.GetTvCreditsAsync(personId, language);
    }
}
