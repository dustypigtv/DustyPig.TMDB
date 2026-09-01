using DustyPig.TMDB.Models.Account;
using DustyPig.TMDB.Models.Common;

namespace TestsProject.AuthenticatedTests;

[TestClass]
public class TestAccountMethods
{
    [TestMethod]
    [DoNotParallelize]
    public async Task AddFavorites()
    {
        var client = ClientFactory.GetClient();
        int accountId = int.Parse(Environment.GetEnvironmentVariable("TMDB_API_ACCOUNT_ID"));
        string sessionId = Environment.GetEnvironmentVariable("TMDB_API_SESSION_ID");

        var postData = new AddFavorite
        {
            Favorite = true,
            MediaId = Constants.MOVIE_ID,
            MediaType = CommonMediaTypes.Movie
        };

        var ret = await client.Endpoints.Account.AddFavoriteAsync(postData, accountId, sessionId);
        Assert.IsEmpty(ret.Data.AdditionalProperties);

        postData = new AddFavorite
        {
            Favorite = false,
            MediaId = Constants.TV_SERIES_ID,
            MediaType = CommonMediaTypes.TvSeries
        };

        ret = await client.Endpoints.Account.AddFavoriteAsync(postData, accountId, sessionId);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
    }


    [TestMethod]
    [DoNotParallelize]
    public async Task AddToWatchlist()
    {
        var client = ClientFactory.GetClient();
        int accountId = int.Parse(Environment.GetEnvironmentVariable("TMDB_API_ACCOUNT_ID"));
        string sessionId = Environment.GetEnvironmentVariable("TMDB_API_SESSION_ID");

        var postData = new AddToWatchlist
        {
            MediaId = Constants.MOVIE_ID,
            MediaType = CommonMediaTypes.Movie,
            Watchlist = true
        };

        var ret = await client.Endpoints.Account.AddToWatchlistAsync(postData, accountId, sessionId);
        Assert.IsEmpty(ret.Data.AdditionalProperties);

        postData = new AddToWatchlist
        {
            MediaId = Constants.TV_SERIES_ID,
            MediaType = CommonMediaTypes.TvSeries,
            Watchlist = false
        };

        ret = await client.Endpoints.Account.AddToWatchlistAsync(postData, accountId, sessionId);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
    }

    [TestMethod]
    [DoNotParallelize]
    public async Task GetFavoriteMovies()
    {
        int accountId = int.Parse(Environment.GetEnvironmentVariable("TMDB_API_ACCOUNT_ID"));
        string sessionId = Environment.GetEnvironmentVariable("TMDB_API_SESSION_ID");

        int page = 1;
        string language = Constants.Language;
        CommonSortByCreated sortBy = CommonSortByCreated.CreatedAtAsc;

        //var ret = await ClientFactory.GetClient().Endpoints.Account.GetFavoriteMoviesAsync(accountId, page, language, sessionId, sortBy);
        var ret = await ClientFactory.GetClient().Endpoints.Account.GetFavoriteMoviesAsync(accountId, page, language, sessionId, sortBy);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var item in ret.Data.Results)
            Assert.IsEmpty(item.AdditionalProperties);
    }

    [TestMethod]
    [DoNotParallelize]
    public async Task GetFavoriteTvSeries()
    {
        int accountId = int.Parse(Environment.GetEnvironmentVariable("TMDB_API_ACCOUNT_ID"));
        string sessionId = Environment.GetEnvironmentVariable("TMDB_API_SESSION_ID");

        int page = 1;
        string language = Constants.Language;
        CommonSortByCreated sortBy = CommonSortByCreated.CreatedAtAsc;

        //var ret = await ClientFactory.GetClient().Endpoints.Account.GetFavoriteTvSeriesAsync(accountId, page, language, sessionId, sortBy);
        var ret = await ClientFactory.GetClient().Endpoints.Account.GetFavoriteTvSeriesAsync(accountId, page, language, sessionId, sortBy);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var item in ret.Data.Results)
            Assert.IsEmpty(item.AdditionalProperties);
    }


    [TestMethod]
    [DoNotParallelize]
    public async Task GetDetails()
    {
        string sessionId = Environment.GetEnvironmentVariable("TMDB_API_SESSION_ID");
        var ret = await ClientFactory.GetClient().Endpoints.Account.GetDetailsAsync(sessionId);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        Assert.IsEmpty(ret.Data.Avatar?.AdditionalProperties);
        Assert.IsEmpty(ret.Data.Avatar?.Gravatar?.AdditionalProperties);
        Assert.IsEmpty(ret.Data.Avatar?.Tmdb?.AdditionalProperties);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetLists()
    {
        int accountId = int.Parse(Environment.GetEnvironmentVariable("TMDB_API_ACCOUNT_ID"));
        string sessionId = Environment.GetEnvironmentVariable("TMDB_API_SESSION_ID");

        int page = 1;

        var ret = await ClientFactory.GetClient().Endpoints.Account.GetListsAsync(accountId, page, sessionId);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var item in ret.Data.Results)
            Assert.IsEmpty(item.AdditionalProperties);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetRatedMovies()
    {
        int accountId = int.Parse(Environment.GetEnvironmentVariable("TMDB_API_ACCOUNT_ID"));
        string sessionId = Environment.GetEnvironmentVariable("TMDB_API_SESSION_ID");

        int page = 1;
        string language = Constants.Language;
        CommonSortByCreated sortBy = CommonSortByCreated.CreatedAtAsc;

        var ret = await ClientFactory.GetClient().Endpoints.Account.GetRatedMoviesAsync(accountId, page, language, sessionId, sortBy);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var item in ret.Data.Results)
            Assert.IsEmpty(item.AdditionalProperties);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetRatedTvSeries()
    {
        int accountId = int.Parse(Environment.GetEnvironmentVariable("TMDB_API_ACCOUNT_ID"));
        string sessionId = Environment.GetEnvironmentVariable("TMDB_API_SESSION_ID");

        int page = 1;
        string language = Constants.Language;
        CommonSortByCreated sortBy = CommonSortByCreated.CreatedAtAsc;

        var ret = await ClientFactory.GetClient().Endpoints.Account.GetRatedTvSeriesAsync(accountId, page, language, sessionId, sortBy);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var item in ret.Data.Results)
            Assert.IsEmpty(item.AdditionalProperties);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetRatedTvEpisodes()
    {
        int accountId = int.Parse(Environment.GetEnvironmentVariable("TMDB_API_ACCOUNT_ID"));
        string sessionId = Environment.GetEnvironmentVariable("TMDB_API_SESSION_ID");

        int page = 1;
        string language = Constants.Language;
        CommonSortByCreated sortBy = CommonSortByCreated.CreatedAtAsc;

        var ret = await ClientFactory.GetClient().Endpoints.Account.GetRatedTvEpisodesAsync(accountId, page, language, sessionId, sortBy);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var item in ret.Data.Results)
            Assert.IsEmpty(item.AdditionalProperties);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetWatchlistMovies()
    {
        int accountId = int.Parse(Environment.GetEnvironmentVariable("TMDB_API_ACCOUNT_ID"));
        string sessionId = Environment.GetEnvironmentVariable("TMDB_API_SESSION_ID");

        int page = 1;
        string language = Constants.Language;
        CommonSortByCreated sortBy = CommonSortByCreated.CreatedAtAsc;

        var ret = await ClientFactory.GetClient().Endpoints.Account.GetWatchlistMoviesAsync(accountId, page, language, sessionId, sortBy);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var item in ret.Data.Results)
            Assert.IsEmpty(item.AdditionalProperties);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetWatchlistTvSeries()
    {
        int accountId = int.Parse(Environment.GetEnvironmentVariable("TMDB_API_ACCOUNT_ID"));
        string sessionId = Environment.GetEnvironmentVariable("TMDB_API_SESSION_ID");

        int page = 1;
        string language = Constants.Language;
        CommonSortByCreated sortBy = CommonSortByCreated.CreatedAtAsc;

        var ret = await ClientFactory.GetClient().Endpoints.Account.GetWatchlistTvSeriesAsync(accountId, page, language, sessionId, sortBy);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var item in ret.Data.Results)
            Assert.IsEmpty(item.AdditionalProperties);
    }
}
