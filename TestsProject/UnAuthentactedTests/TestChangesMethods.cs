using Microsoft.VisualStudio.TestTools.UnitTesting;

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

        await ClientFactory.GetClient().Endpoints.Changes.GetMoviesAsync(page, endDate, startDate);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetPeople()
    {
        int page = 1;
        DateOnly? startDate = DateOnly.FromDateTime(DateTime.Today.AddMonths(-1));
        DateOnly? endDate = null;

        await ClientFactory.GetClient().Endpoints.Changes.GetPeopleAsync(page, endDate, startDate);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetTvSeries()
    {
        int page = 1;
        DateOnly? startDate = DateOnly.FromDateTime(DateTime.Today.AddMonths(-1));
        DateOnly? endDate = null;

        await ClientFactory.GetClient().Endpoints.Changes.GetTvSeriesAsync(page, endDate, startDate);
    }
}