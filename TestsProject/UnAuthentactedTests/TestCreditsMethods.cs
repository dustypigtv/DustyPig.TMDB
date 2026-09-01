namespace TestsProject.UnAuthentactedTests;

[TestClass]
public class TestCreditsMethods
{
    [TestMethod]
    [DoNotParallelize]
    public async Task GetDetails()
    {
        string creditId = Constants.CREDIT_ID;

        var ret = await ClientFactory.GetClient().Endpoints.Credits.GetDetailsAsync(creditId);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        Assert.IsEmpty(ret.Data.Media.AdditionalProperties);
        Assert.IsEmpty(ret.Data.Person.AdditionalProperties);
    }
}
