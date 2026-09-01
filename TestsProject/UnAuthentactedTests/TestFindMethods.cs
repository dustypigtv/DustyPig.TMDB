using DustyPig.TMDB.Models.Find;

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

        var ret = await ClientFactory.GetClient().Endpoints.Find.ByIdAsync(externalId, externalSource, language);
        Assert.IsTrue(ret.Data.MovieResults.Any(_ => _.Id == Constants.MOVIE_ID));
        AdditionalPropertiesChecker.Check(ret);
    }

    [TestMethod]
    [DoNotParallelize]
    public async Task BySeriesTvdbId()
    {
        string externalId = Constants.TVDB_TV_SERIES_ID.ToString();
        Externalsource externalSource = Externalsource.TvdbId;
        string language = Constants.Language;

        var ret = await ClientFactory.GetClient().Endpoints.Find.ByIdAsync(externalId, externalSource, language);
        Assert.IsTrue(ret.Data.TvResults.Any(_ => _.Id == Constants.TV_SERIES_ID));
        AdditionalPropertiesChecker.Check(ret);
    }


    [TestMethod]
    [DoNotParallelize]
    public async Task ByPersonImdbId()
    {
        string externalId = Constants.IMDB_PERSON_ID;
        Externalsource externalSource = Externalsource.ImdbId;
        string language = Constants.Language;

        var ret = await ClientFactory.GetClient().Endpoints.Find.ByIdAsync(externalId, externalSource, language);
        Assert.IsTrue(ret.Data.PersonResults.Any(_ => _.Id == Constants.PERSON_ID));
        AdditionalPropertiesChecker.Check(ret);
    }

    [TestMethod]
    [DoNotParallelize]
    public async Task BySeasonTvdbId()
    {
        string externalId = Constants.TVDB_SEASON_ID.ToString();
        Externalsource externalSource = Externalsource.TvdbId;
        string language = Constants.Language;

        var ret = await ClientFactory.GetClient().Endpoints.Find.ByIdAsync(externalId, externalSource, language);
        Assert.IsTrue(ret.Data.TvSeasonResults.Any(_ => _.Id == Constants.SEASON_ID));
        AdditionalPropertiesChecker.Check(ret);
    }

    [TestMethod]
    [DoNotParallelize]
    public async Task ByEpisodeImdbId()
    {
        string externalId = Constants.IMDB_EPISODE_ID;
        Externalsource externalSource = Externalsource.ImdbId;
        string language = Constants.Language;

        var ret = await ClientFactory.GetClient().Endpoints.Find.ByIdAsync(externalId, externalSource, language);
        Assert.IsTrue(ret.Data.TvEpisodeResults.Any(_ => _.Id == Constants.EPISODE_ID));
        AdditionalPropertiesChecker.Check(ret);
    }
}
