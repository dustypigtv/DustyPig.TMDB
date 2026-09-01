namespace TestsProject.UnAuthentactedTests;

[TestClass]
public class TestKeywordsMethods
{
    [TestMethod]
    [DoNotParallelize]
    public async Task GetDetails()
    {
        int keywordId = Constants.KEYWORK_ID;

        var ret = await ClientFactory.GetClient().Endpoints.Keywords.GetDetailsAsync(keywordId);
        AdditionalPropertiesChecker.Check(ret);
    }
}
