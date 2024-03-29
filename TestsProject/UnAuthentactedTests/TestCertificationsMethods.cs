using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsProject.UnAuthentactedTests;

[TestClass]
public class TestCertificationsMethods
{
    [TestMethod]
    [DoNotParallelize]
    public async Task GetMovieCertifications()
    {
        await ClientFactory.GetClient().Endpoints.Certifications.GetMovieCertificationsAsync();
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetTvSeriesCertifications()
    {
        await ClientFactory.GetClient().Endpoints.Certifications.GetTvSeriesCertificationsAsync();
    }
}
