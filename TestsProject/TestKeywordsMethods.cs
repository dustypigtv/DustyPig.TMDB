using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsProject;

[TestClass]
public class TestKeywordsMethods
{
    [TestMethod]
    [DoNotParallelize]
    public async Task GetDetailsAsync()
    {
        int keywordId = Constants.KEYWORK_ID;

        await ClientFactory.GetClient().Endpoints.Keywords.GetDetailsAsync(keywordId);
    }
}
