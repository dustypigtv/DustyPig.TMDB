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

        var response = await ClientFactory.GetClient().Endpoints.Find.ByIdAsync(externalId, externalSource, language);
        Assert.IsTrue(response.Data.MovieResults.Any(_ => _.Id == Constants.MOVIE_ID));
        Assert.IsEmpty(response.Data.AdditionalProperties);
        foreach (var item in response.Data.MovieResults)
            Assert.IsEmpty(item.AdditionalProperties);
        foreach (var item in response.Data.PersonResults)
            Assert.IsEmpty(item.AdditionalProperties);
        foreach (var item in response.Data.TvEpisodeResults)
            Assert.IsEmpty(item.AdditionalProperties);
        foreach (var item in response.Data.TvResults)
            Assert.IsEmpty(item.AdditionalProperties);
        foreach (var item in response.Data.TvSeasonResults)
            Assert.IsEmpty(item.AdditionalProperties);
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
        Assert.IsEmpty(response.Data.AdditionalProperties);
        foreach (var item in response.Data.MovieResults)
            Assert.IsEmpty(item.AdditionalProperties);
        foreach (var item in response.Data.PersonResults)
            Assert.IsEmpty(item.AdditionalProperties);
        foreach (var item in response.Data.TvEpisodeResults)
            Assert.IsEmpty(item.AdditionalProperties);
        foreach (var item in response.Data.TvResults)
            Assert.IsEmpty(item.AdditionalProperties);
        foreach (var item in response.Data.TvSeasonResults)
            Assert.IsEmpty(item.AdditionalProperties);
    }


    [TestMethod]
    [DoNotParallelize]
    public async Task ByPersonImdbId()
    {
        string externalId = Constants.IMDB_PERSON_ID;
        Externalsource externalSource = Externalsource.ImdbId;
        string language = Constants.Language;

        var response = await ClientFactory.GetClient().Endpoints.Find.ByIdAsync(externalId, externalSource, language);
        Assert.IsTrue(response.Data.PersonResults.Any(_ => _.Id == Constants.PERSON_ID));
        Assert.IsEmpty(response.Data.AdditionalProperties);
        foreach (var item in response.Data.MovieResults)
            Assert.IsEmpty(item.AdditionalProperties);
        foreach (var item in response.Data.PersonResults)
            Assert.IsEmpty(item.AdditionalProperties);
        foreach (var item in response.Data.TvEpisodeResults)
            Assert.IsEmpty(item.AdditionalProperties);
        foreach (var item in response.Data.TvResults)
            Assert.IsEmpty(item.AdditionalProperties);
        foreach (var item in response.Data.TvSeasonResults)
            Assert.IsEmpty(item.AdditionalProperties);
    }

    [TestMethod]
    [DoNotParallelize]
    public async Task BySeasonTvdbId()
    {
        string externalId = Constants.TVDB_SEASON_ID.ToString();
        Externalsource externalSource = Externalsource.TvdbId;
        string language = Constants.Language;

        var response = await ClientFactory.GetClient().Endpoints.Find.ByIdAsync(externalId, externalSource, language);
        Assert.IsTrue(response.Data.TvSeasonResults.Any(_ => _.Id == Constants.SEASON_ID));
        Assert.IsEmpty(response.Data.AdditionalProperties);
        foreach (var item in response.Data.MovieResults)
            Assert.IsEmpty(item.AdditionalProperties);
        foreach (var item in response.Data.PersonResults)
            Assert.IsEmpty(item.AdditionalProperties);
        foreach (var item in response.Data.TvEpisodeResults)
            Assert.IsEmpty(item.AdditionalProperties);
        foreach (var item in response.Data.TvResults)
            Assert.IsEmpty(item.AdditionalProperties);
        foreach (var item in response.Data.TvSeasonResults)
            Assert.IsEmpty(item.AdditionalProperties);
    }

    [TestMethod]
    [DoNotParallelize]
    public async Task ByEpisodeImdbId()
    {
        string externalId = Constants.IMDB_EPISODE_ID;
        Externalsource externalSource = Externalsource.ImdbId;
        string language = Constants.Language;

        var response = await ClientFactory.GetClient().Endpoints.Find.ByIdAsync(externalId, externalSource, language);
        Assert.IsTrue(response.Data.TvEpisodeResults.Any(_ => _.Id == Constants.EPISODE_ID));
        Assert.IsEmpty(response.Data.AdditionalProperties);
        foreach (var item in response.Data.MovieResults)
            Assert.IsEmpty(item.AdditionalProperties);
        foreach (var item in response.Data.PersonResults)
            Assert.IsEmpty(item.AdditionalProperties);
        foreach (var item in response.Data.TvEpisodeResults)
            Assert.IsEmpty(item.AdditionalProperties);
        foreach (var item in response.Data.TvResults)
            Assert.IsEmpty(item.AdditionalProperties);
        foreach (var item in response.Data.TvSeasonResults)
            Assert.IsEmpty(item.AdditionalProperties);
    }
}
