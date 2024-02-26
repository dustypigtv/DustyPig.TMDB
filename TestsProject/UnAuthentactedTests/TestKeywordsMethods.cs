using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsProject.UnAuthentactedTests;

[TestClass]
public class TestKeywordsMethods
{
    [TestMethod]
    [DoNotParallelize]
    public async Task GetDetails()
    {
        int keywordId = Constants.KEYWORK_ID;

        await ClientFactory.GetClient().Endpoints.Keywords.GetDetailsAsync(keywordId);
    }
}
