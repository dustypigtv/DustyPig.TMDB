namespace TestsProject.UnAuthentactedTests;

[TestClass]
public class TestChangesMethods
{
    [TestMethod]
    [DoNotParallelize]
    public async Task GetMovies()
    {
        int page = 1;
        DateOnly? startDate = DateOnly.FromDateTime(DateTime.Today.AddMonths(-1));
        DateOnly? endDate = null;

        var ret = await ClientFactory.GetClient().Endpoints.Changes.GetMoviesAsync(page, endDate, startDate);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var item in ret.Data.Results)
            Assert.IsEmpty(item.AdditionalProperties);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetPeople()
    {
        int page = 1;
        DateOnly? startDate = DateOnly.FromDateTime(DateTime.Today.AddMonths(-1));
        DateOnly? endDate = null;

        var ret = await ClientFactory.GetClient().Endpoints.Changes.GetPeopleAsync(page, endDate, startDate);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var item in ret.Data.Results)
            Assert.IsEmpty(item.AdditionalProperties);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetTvSeries()
    {
        int page = 1;
        DateOnly? startDate = DateOnly.FromDateTime(DateTime.Today.AddMonths(-1));
        DateOnly? endDate = null;

        var ret = await ClientFactory.GetClient().Endpoints.Changes.GetTvSeriesAsync(page, endDate, startDate);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var item in ret.Data.Results)
            Assert.IsEmpty(item.AdditionalProperties);
    }
}