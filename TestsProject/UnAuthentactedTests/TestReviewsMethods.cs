using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsProject.UnAuthentactedTests;

[TestClass]
public class TestReviewsMethods
{
    [TestMethod]
    [DoNotParallelize]
    public async Task GetDetails()
    {
        string reviewId = "4fce8f8819c29523880000de";

        await ClientFactory.GetClient().Endpoints.Reviews.GetDetailsAsync(reviewId);
    }
}
