using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsProject.UnAuthentactedTests;

[TestClass]
public class TestChangesMethods
{
    [TestMethod]
    [DoNotParallelize]
    public async Task GetMovieList()
    {
        int page = 1;
        DateOnly? startDate = DateOnly.FromDateTime(DateTime.Today.AddMonths(-1));
        DateOnly? endDate = null;

        await ClientFactory.GetClient().Endpoints.Changes.GetMovieListAsync(page, endDate, startDate);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetPeopleList()
    {
        int page = 1;
        DateOnly? startDate = DateOnly.FromDateTime(DateTime.Today.AddMonths(-1));
        DateOnly? endDate = null;

        await ClientFactory.GetClient().Endpoints.Changes.GetPeopleListAsync(page, endDate, startDate);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetTvSeriesList()
    {
        int page = 1;
        DateOnly? startDate = DateOnly.FromDateTime(DateTime.Today.AddMonths(-1));
        DateOnly? endDate = null;

        await ClientFactory.GetClient().Endpoints.Changes.GetTvListAsync(page, endDate, startDate);
    }
}