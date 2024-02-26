using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsProject.UnAuthentactedTests;

[TestClass]
public class TestCreditsMethods
{
    [TestMethod]
    [DoNotParallelize]
    public async Task GetDetails()
    {
        string creditId = Constants.CREDIT_ID;

        await ClientFactory.GetClient().Endpoints.Credits.GetDetailsAsync(creditId);
    }
}
