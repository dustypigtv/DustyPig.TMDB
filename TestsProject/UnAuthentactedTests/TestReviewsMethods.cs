namespace TestsProject.UnAuthentactedTests;

[TestClass]
public class TestReviewsMethods
{
    [TestMethod]
    [DoNotParallelize]
    public async Task GetDetails()
    {
        string reviewId = "4fce8f8819c29523880000de";

        var ret = await ClientFactory.GetClient().Endpoints.Reviews.GetDetailsAsync(reviewId);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        Assert.IsEmpty(ret.Data.AuthorDetails.AdditionalProperties);
    }
}
