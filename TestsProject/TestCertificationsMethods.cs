using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsProject;

[TestClass]
public class TestCertificationsMethods
{
	[TestMethod]
	[DoNotParallelize]
	public async Task GetMovieCertificationsAsync()
	{
		await ClientFactory.GetClient().Endpoints.Certifications.GetMovieCertificationsAsync();
	}



	[TestMethod]
	[DoNotParallelize]
	public async Task GetTvCertificationsAsync()
	{
		await ClientFactory.GetClient().Endpoints.Certifications.GetTvCertificationsAsync();
	}
}
