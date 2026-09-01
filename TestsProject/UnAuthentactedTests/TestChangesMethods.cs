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
        AdditionalPropertiesChecker.Check(ret);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetPeople()
    {
        int page = 1;
        DateOnly? startDate = DateOnly.FromDateTime(DateTime.Today.AddMonths(-1));
        DateOnly? endDate = null;

        var ret = await ClientFactory.GetClient().Endpoints.Changes.GetPeopleAsync(page, endDate, startDate);
        AdditionalPropertiesChecker.Check(ret);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetTvSeries()
    {
        int page = 1;
        DateOnly? startDate = DateOnly.FromDateTime(DateTime.Today.AddMonths(-1));
        DateOnly? endDate = null;

        var ret = await ClientFactory.GetClient().Endpoints.Changes.GetTvSeriesAsync(page, endDate, startDate);
        AdditionalPropertiesChecker.Check(ret);
    }
}