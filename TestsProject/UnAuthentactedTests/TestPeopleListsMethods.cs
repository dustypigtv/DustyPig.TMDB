using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsProject.UnAuthentactedTests;

[TestClass]
public class TestPeopleListsMethods
{
    [TestMethod]
    [DoNotParallelize]
    public async Task GetPopular()
    {
        int page = 1;
        string language = Constants.Language;

        await ClientFactory.GetClient().Endpoints.PeopleLists.GetPopularAsync(page, language);
    }
}
