using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsProject;

[TestClass]
public class TestSearchMethods
{
    [TestMethod]
    [DoNotParallelize]
    public async Task GetCollectionAsync()
    {
        //string query = ;
        int page = 1;
        bool? includeAdult = null;
        string language = "en-US";
        string region = null;

        //await ClientFactory.GetClient().Endpoints.Search.GetCollectionAsync(query, page, includeAdult, language, region);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetCompanyAsync()
    {
        //string query = ;
        int page = 1;

        //await ClientFactory.GetClient().Endpoints.Search.GetCompanyAsync(query, page);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetKeywordAsync()
    {
        //string query = ;
        int page = 1;

        //await ClientFactory.GetClient().Endpoints.Search.GetKeywordAsync(query, page);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetMovieAsync()
    {
        //string query = ;
        int page = 1;
        bool? includeAdult = null;
        string language = "en-US";
        int? primaryReleaseYear = null;
        string region = null;
        int? year = null;

        //await ClientFactory.GetClient().Endpoints.Search.GetMovieAsync(query, page, includeAdult, language, primaryReleaseYear, region, year);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetMultiAsync()
    {
        //string query = ;
        int page = 1;
        bool? includeAdult = null;
        string language = "en-US";

        //await ClientFactory.GetClient().Endpoints.Search.GetMultiAsync(query, page, includeAdult, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetPersonAsync()
    {
        //string query = ;
        int page = 1;
        bool? includeAdult = null;
        string language = "en-US";

        //await ClientFactory.GetClient().Endpoints.Search.GetPersonAsync(query, page, includeAdult, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetTvAsync()
    {
        //string query = ;
        int page = 1;
        int? firstAirDateYear = null;
        bool? includeAdult = null;
        string language = "en-US";
        int? year = null;

        //await ClientFactory.GetClient().Endpoints.Search.GetTvAsync(query, page, firstAirDateYear, includeAdult, language, year);
    }
}
