using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

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
        string query = "The Avengers";
        int page = 1;
        bool? includeAdult = null;
        string language = "en-US";
        int? primaryReleaseYear = null;
        string region = null;
        int? year = 2012;

        var ret = await ClientFactory.GetClient().Endpoints.Search.GetMovieAsync(query, page, includeAdult, language, primaryReleaseYear, region, year);
        Debug.Assert(ret.Data.Results[0].Id == Constants.MOVIE_ID);
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
    public async Task GetTvSeriesAsync()
    {
        string query = "Buffy the Vampire Slayer";
        int page = 1;
        int? firstAirDateYear = null;
        bool? includeAdult = null;
        string language = "en-US";
        int? year = null;

        var ret = await ClientFactory.GetClient().Endpoints.Search.GetTvSeriesAsync(query, page, firstAirDateYear, includeAdult, language, year);
        Debug.Assert(ret.Data.Results.Any(item => item.Id == Constants.TV_SERIES_ID));
    }
}
