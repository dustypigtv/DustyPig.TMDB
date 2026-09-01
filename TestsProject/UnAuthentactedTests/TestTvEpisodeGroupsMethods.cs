namespace TestsProject.UnAuthentactedTests;

[TestClass]
public class TestTvEpisodeGroupsMethods
{
    [TestMethod]
    [DoNotParallelize]
    public async Task GetDetails()
    {
        string tvEpisodeGroupId = "5e99d20afdf8b70013a4ca8f";

        var ret = await ClientFactory.GetClient().Endpoints.TvEpisodeGroups.GetDetailsAsync(tvEpisodeGroupId);
        AdditionalPropertiesChecker.Check(ret);
    }
}
