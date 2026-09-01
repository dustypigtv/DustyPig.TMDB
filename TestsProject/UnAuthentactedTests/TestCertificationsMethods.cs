namespace TestsProject.UnAuthentactedTests;

[TestClass]
public class TestCertificationsMethods
{
    [TestMethod]
    [DoNotParallelize]
    public async Task GetMovieCertifications()
    {
        var ret = await ClientFactory.GetClient().Endpoints.Certifications.GetMovieCertificationsAsync();
        AdditionalPropertiesChecker.Check(ret);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetTvSeriesCertifications()
    {
        var ret = await ClientFactory.GetClient().Endpoints.Certifications.GetTvSeriesCertificationsAsync();
        AdditionalPropertiesChecker.Check(ret);
    }
}
