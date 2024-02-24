using DustyPig.TMDB.Models.TvEpisodes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsProject;

[TestClass]
public class TestTvEpisodesMethods
{
    [TestMethod]
    [DoNotParallelize]
    public async Task GetAccountStatesAsync()
    {
        //int episodeNumber = ;
        //int seasonNumber = ;
        //int seriesId = ;
        string guestSessionId = null;
        string sessionId = null;

        //await ClientFactory.GetClient().Endpoints.TvEpisodes.GetAccountStatesAsync(episodeNumber, seasonNumber, seriesId, guestSessionId, sessionId);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task AddRatingAsync()
    {
        //CommonValue1 postData = ;
        //int episodeNumber = ;
        //int seasonNumber = ;
        //int seriesId = ;
        string guestSessionId = null;
        string sessionId = null;

        //await ClientFactory.GetClient().Endpoints.TvEpisodes.AddRatingAsync(postData, episodeNumber, seasonNumber, seriesId, guestSessionId, sessionId);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetChangesAsync()
    {
        //int episodeId = ;

        //await ClientFactory.GetClient().Endpoints.TvEpisodes.GetChangesAsync(episodeId);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetCreditsAsync()
    {
        //int episodeNumber = ;
        //int seasonNumber = ;
        //int seriesId = ;
        string language = "en-US";

        //await ClientFactory.GetClient().Endpoints.TvEpisodes.GetCreditsAsync(episodeNumber, seasonNumber, seriesId, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetDetailsAsync()
    {
        //int episodeNumber = ;
        //int seasonNumber = ;
        //int seriesId = ;
        AppendToResponse? appendToResponse = null;
        string language = "en-US";

        //await ClientFactory.GetClient().Endpoints.TvEpisodes.GetDetailsAsync(episodeNumber, seasonNumber, seriesId, appendToResponse, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetExternalIdsAsync()
    {
        //string episodeNumber = ;
        //int seasonNumber = ;
        //int seriesId = ;

        //await ClientFactory.GetClient().Endpoints.TvEpisodes.GetExternalIdsAsync(episodeNumber, seasonNumber, seriesId);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetImagesAsync()
    {
        //int episodeNumber = ;
        //int seasonNumber = ;
        //int seriesId = ;
        string includeImageLanguage = null;
        string language = "en-US";

        //await ClientFactory.GetClient().Endpoints.TvEpisodes.GetImagesAsync(episodeNumber, seasonNumber, seriesId, includeImageLanguage, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetTranslationsAsync()
    {
        //int episodeNumber = ;
        //int seasonNumber = ;
        //int seriesId = ;

        //await ClientFactory.GetClient().Endpoints.TvEpisodes.GetTranslationsAsync(episodeNumber, seasonNumber, seriesId);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetVideosAsync()
    {
        //int episodeNumber = ;
        //int seasonNumber = ;
        //int seriesId = ;
        string includeVideoLanguage = null;
        string language = "en-US";

        //await ClientFactory.GetClient().Endpoints.TvEpisodes.GetVideosAsync(episodeNumber, seasonNumber, seriesId, includeVideoLanguage, language);
    }
}
