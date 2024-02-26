using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsProject.UnAuthentactedTests;

[TestClass]
public class TestTvEpisodeGroupsMethods
{
    [TestMethod]
    [DoNotParallelize]
    public async Task GetDetails()
    {
        string tvEpisodeGroupId = "5e99d20afdf8b70013a4ca8f";

        await ClientFactory.GetClient().Endpoints.TvEpisodeGroups.GetDetailsAsync(tvEpisodeGroupId);
    }
}
