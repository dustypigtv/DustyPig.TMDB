using DustyPig.TMDB.Models.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsProject;

//[TestClass]
public class TestAccountMethods
{
    [TestMethod]
    [DoNotParallelize]
    public async Task AddFavoriteAsync()
    {
        //AddFavorite postData = ;
        //int accountId = ;
        string sessionId = null;

        //await ClientFactory.GetClient().Endpoints.Account.AddFavoriteAsync(postData, accountId, sessionId);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task AddToWatchlistAsync()
    {
        //AddToWatchlist postData = ;
        //int accountId = ;
        string sessionId = null;

        //await ClientFactory.GetClient().Endpoints.Account.AddToWatchlistAsync(postData, accountId, sessionId);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetDetailsAsync()
    {
        //int accountId = ;
        string sessionId = null;

        //await ClientFactory.GetClient().Endpoints.Account.GetDetailsAsync(accountId, sessionId);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetFavoriteMoviesAsync()
    {
        //int accountId = ;
        int page = 1;
        string language = "en-US";
        string sessionId = null;
        CommonSortByCreated sortBy = CommonSortByCreated.CreatedAtAsc;

        //await ClientFactory.GetClient().Endpoints.Account.GetFavoriteMoviesAsync(accountId, page, language, sessionId, sortBy);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetFavoriteTvAsync()
    {
        //int accountId = ;
        int page = 1;
        string language = "en-US";
        string sessionId = null;
        CommonSortByCreated sortBy = CommonSortByCreated.CreatedAtAsc;

        //await ClientFactory.GetClient().Endpoints.Account.GetFavoriteTvAsync(accountId, page, language, sessionId, sortBy);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetListsAsync()
    {
        //int accountId = ;
        int page = 1;
        string sessionId = null;

        //await ClientFactory.GetClient().Endpoints.Account.GetListsAsync(accountId, page, sessionId);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetRatedMoviesAsync()
    {
        //int accountId = ;
        int page = 1;
        string language = "en-US";
        string sessionId = null;
        CommonSortByCreated sortBy = CommonSortByCreated.CreatedAtAsc;

        //await ClientFactory.GetClient().Endpoints.Account.GetRatedMoviesAsync(accountId, page, language, sessionId, sortBy);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetRatedTvAsync()
    {
        //int accountId = ;
        int page = 1;
        string language = "en-US";
        string sessionId = null;
        CommonSortByCreated sortBy = CommonSortByCreated.CreatedAtAsc;

        //await ClientFactory.GetClient().Endpoints.Account.GetRatedTvAsync(accountId, page, language, sessionId, sortBy);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetRatedTvEpisodesAsync()
    {
        //int accountId = ;
        int page = 1;
        string language = "en-US";
        string sessionId = null;
        CommonSortByCreated sortBy = CommonSortByCreated.CreatedAtAsc;

        //await ClientFactory.GetClient().Endpoints.Account.GetRatedTvEpisodesAsync(accountId, page, language, sessionId, sortBy);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetWatchlistMoviesAsync()
    {
        //int accountId = ;
        int page = 1;
        string language = "en-US";
        string sessionId = null;
        CommonSortByCreated sortBy = CommonSortByCreated.CreatedAtAsc;

        //await ClientFactory.GetClient().Endpoints.Account.GetWatchlistMoviesAsync(accountId, page, language, sessionId, sortBy);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetWatchlistTvAsync()
    {
        //int accountId = ;
        int page = 1;
        string language = "en-US";
        string sessionId = null;
        CommonSortByCreated sortBy = CommonSortByCreated.CreatedAtAsc;

        //await ClientFactory.GetClient().Endpoints.Account.GetWatchlistTvAsync(accountId, page, language, sessionId, sortBy);
    }
}
