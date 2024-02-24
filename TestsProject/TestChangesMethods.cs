using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsProject;

[TestClass]
public class TestChangesMethods
{
    [TestMethod]
    [DoNotParallelize]
    public async Task GetMovieListAsync()
    {
        int page = 1;
        DateOnly? endDate = null;
        DateOnly? startDate = null;

        await ClientFactory.GetClient().Endpoints.Changes.GetMovieListAsync(page, endDate, startDate);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetPeopleListAsync()
    {
        int page = 1;
        DateOnly? endDate = null;
        DateOnly? startDate = null;

        await ClientFactory.GetClient().Endpoints.Changes.GetPeopleListAsync(page, endDate, startDate);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetTvListAsync()
    {
        int page = 1;
        DateOnly? endDate = null;
        DateOnly? startDate = null;

        await ClientFactory.GetClient().Endpoints.Changes.GetTvListAsync(page, endDate, startDate);
    }
}
