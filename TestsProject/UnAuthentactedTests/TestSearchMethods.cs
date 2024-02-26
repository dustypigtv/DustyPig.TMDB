using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsProject.UnAuthentactedTests;

[TestClass]
public class TestSearchMethods
{
    [TestMethod]
    [DoNotParallelize]
    public async Task Collections()
    {
        string query = "The Avengers";
        int page = 1;
        bool? includeAdult = null;
        string language = Constants.Language;
        string region = null;

        await ClientFactory.GetClient().Endpoints.Search.CollectionsAsync(query, page, includeAdult, language, region);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task Companies()
    {
        string query = "Marvel Studios";
        int page = 1;

        await ClientFactory.GetClient().Endpoints.Search.CompaniesAsync(query, page);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task Keywords()
    {
        string query = "superhero";
        int page = 1;

        await ClientFactory.GetClient().Endpoints.Search.KeywordsAsync(query, page);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task Movies()
    {
        string query = "The Avengers";
        int page = 1;
        bool? includeAdult = null;
        string language = Constants.Language;
        int? primaryReleaseYear = null;
        string region = null;
        int? year = 2012;

        await ClientFactory.GetClient().Endpoints.Search.MoviesAsync(query, page, includeAdult, language, primaryReleaseYear, region, year);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task Multi()
    {
        string query = "The Avengers";
        int page = 1;
        bool? includeAdult = null;
        string language = Constants.Language;

        await ClientFactory.GetClient().Endpoints.Search.MultiAsync(query, page, includeAdult, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task People()
    {
        string query = "Harrison Ford";
        int page = 1;
        bool? includeAdult = null;
        string language = Constants.Language;

        await ClientFactory.GetClient().Endpoints.Search.PeopleAsync(query, page, includeAdult, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task TvSeries()
    {
        string query = "Buffy the Vampire Slayer";
        int page = 1;
        int? firstAirDateYear = null;
        bool? includeAdult = null;
        string language = Constants.Language;
        int? year = null;

        await ClientFactory.GetClient().Endpoints.Search.TvSeriesAsync(query, page, firstAirDateYear, includeAdult, language, year);
    }
}
