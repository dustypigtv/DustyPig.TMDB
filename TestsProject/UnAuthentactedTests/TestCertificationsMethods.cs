namespace TestsProject.UnAuthentactedTests;

[TestClass]
public class TestCertificationsMethods
{
    [TestMethod]
    [DoNotParallelize]
    public async Task GetMovieCertifications()
    {
        var ret = await ClientFactory.GetClient().Endpoints.Certifications.GetMovieCertificationsAsync();
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var key in ret.Data.Certifications.Keys)
            foreach (var item in ret.Data.Certifications[key])
                Assert.IsEmpty(item.AdditionalProperties);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetTvSeriesCertifications()
    {
        var ret = await ClientFactory.GetClient().Endpoints.Certifications.GetTvSeriesCertificationsAsync();
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var key in ret.Data.Certifications.Keys)
            foreach (var item in ret.Data.Certifications[key])
                Assert.IsEmpty(item.AdditionalProperties);
    }
}
