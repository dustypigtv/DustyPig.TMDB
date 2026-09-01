namespace TestsProject.UnAuthentactedTests;

[TestClass]
public class TestCreditsMethods
{
    [TestMethod]
    [DoNotParallelize]
    public async Task GetMovieDetails()
    {
        string creditId = Constants.MOVIE_CREDIT_ID;

        var ret = await ClientFactory.GetClient().Endpoints.Credits.GetDetailsAsync(creditId);
        AdditionalPropertiesChecker.Check(ret);
    }

    [TestMethod]
    [DoNotParallelize]
    public async Task GetTvDetails()
    {
        string creditId = Constants.TV_CREDIT_ID;

        var ret = await ClientFactory.GetClient().Endpoints.Credits.GetDetailsAsync(creditId);
        AdditionalPropertiesChecker.Check(ret);
    }
}
