using DustyPig.TMDB.Models.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsProject;

//[TestClass]
public class TestGuestSessionsMethods
{
    [TestMethod]
    [DoNotParallelize]
    public async Task GetRatedMoviesAsync()
    {
        //string guestSessionId = ;
        int page = 1;
        string language = "en-US";
        CommonSortByCreated sortBy = CommonSortByCreated.CreatedAtAsc;

        //await ClientFactory.GetClient().Endpoints.GuestSessions.GetRatedMoviesAsync(guestSessionId, page, language, sortBy);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetRatedTvAsync()
    {
        //string guestSessionId = ;
        int page = 1;
        string language = "en-US";
        CommonSortByCreated sortBy = CommonSortByCreated.CreatedAtAsc;

        //await ClientFactory.GetClient().Endpoints.GuestSessions.GetRatedTvAsync(guestSessionId, page, language, sortBy);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetRatedTvEpisodesAsync()
    {
        //string guestSessionId = ;
        int page = 1;
        string language = "en-US";
        CommonSortByCreated sortBy = CommonSortByCreated.CreatedAtAsc;

        //await ClientFactory.GetClient().Endpoints.GuestSessions.GetRatedTvEpisodesAsync(guestSessionId, page, language, sortBy);
    }
}
