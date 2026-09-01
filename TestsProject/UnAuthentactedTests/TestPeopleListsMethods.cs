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

        var ret = await ClientFactory.GetClient().Endpoints.PeopleLists.GetPopularAsync(page, language);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var item in ret.Data.Results)
        {
            Assert.IsEmpty(item.AdditionalProperties);
            foreach (var item2 in item.KnownFor)
                Assert.IsEmpty(item2.AdditionalProperties);
        }
    }
}
