using DustyPig.TMDB.Models.Find;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsProject.UnAuthentactedTests;

[TestClass]
public class TestFindMethods
{
    [TestMethod]
    [DoNotParallelize]
    public async Task ByMovieImdbId()
    {
        string externalId = Constants.IMDB_MOVIE_ID;
        Externalsource externalSource = Externalsource.ImdbId;
        string language = Constants.Language;

        var response = await ClientFactory.GetClient().Endpoints.Find.ByIdAsync(externalId, externalSource, language);
        Assert.IsTrue(response.Data.MovieResults.Any(_ => _.Id == Constants.MOVIE_ID));
    }

    [TestMethod]
    [DoNotParallelize]
    public async Task BySeriesTvdbId()
    {
        string externalId = Constants.TVDB_TV_SERIES_ID.ToString();
        Externalsource externalSource = Externalsource.TvdbId;
        string language = Constants.Language;

        var response = await ClientFactory.GetClient().Endpoints.Find.ByIdAsync(externalId, externalSource, language);
        Assert.IsTrue(response.Data.TvResults.Any(_ => _.Id == Constants.TV_SERIES_ID));
    }


    [TestMethod]
    [DoNotParallelize]
    public async Task ByPersonImdbId()
    {
        string externalId = Constants.IMDB_CREDIT_ID;
        Externalsource externalSource = Externalsource.ImdbId;
        string language = Constants.Language;

        var response = await ClientFactory.GetClient().Endpoints.Find.ByIdAsync(externalId, externalSource, language);
        Assert.IsTrue(response.Data.TvResults.Any(_ => _.Id == Constants.TV_SERIES_ID));
    }
}
