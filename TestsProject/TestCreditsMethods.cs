using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsProject;

[TestClass]
public class TestCreditsMethods
{
    [TestMethod]
    [DoNotParallelize]
    public async Task GetDetailsAsync()
    {
        string creditId = Constants.CREDIT_ID;

        await ClientFactory.GetClient().Endpoints.Credits.GetDetailsAsync(creditId);
    }
}
