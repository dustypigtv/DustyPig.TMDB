using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsProject.UnAuthentactedTests;

[TestClass]
public class TestSearchMethods
{
    [TestMethod]
    [DoNotParallelize]
    public async Task GetCollection()
    {
        string query = "The Avengers";
        int page = 1;
        bool? includeAdult = null;
        string language = Constants.Language;
        string region = null;

        await ClientFactory.GetClient().Endpoints.Search.GetCollectionAsync(query, page, includeAdult, language, region);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetCompany()
    {
        string query = "Marvel Studios";
        int page = 1;

        await ClientFactory.GetClient().Endpoints.Search.GetCompanyAsync(query, page);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetKeyword()
    {
        string query = "superhero";
        int page = 1;

        await ClientFactory.GetClient().Endpoints.Search.GetKeywordAsync(query, page);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetMovie()
    {
        string query = "The Avengers";
        int page = 1;
        bool? includeAdult = null;
        string language = Constants.Language;
        int? primaryReleaseYear = null;
        string region = null;
        int? year = 2012;

        await ClientFactory.GetClient().Endpoints.Search.GetMovieAsync(query, page, includeAdult, language, primaryReleaseYear, region, year);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetMulti()
    {
        string query = "The Avengers";
        int page = 1;
        bool? includeAdult = null;
        string language = Constants.Language;

        await ClientFactory.GetClient().Endpoints.Search.GetMultiAsync(query, page, includeAdult, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetPerson()
    {
        string query = "Harrison Ford";
        int page = 1;
        bool? includeAdult = null;
        string language = Constants.Language;

        await ClientFactory.GetClient().Endpoints.Search.GetPersonAsync(query, page, includeAdult, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetTvSeries()
    {
        string query = "Buffy the Vampire Slayer";
        int page = 1;
        int? firstAirDateYear = null;
        bool? includeAdult = null;
        string language = Constants.Language;
        int? year = null;

        await ClientFactory.GetClient().Endpoints.Search.GetTvSeriesAsync(query, page, firstAirDateYear, includeAdult, language, year);
    }
}
