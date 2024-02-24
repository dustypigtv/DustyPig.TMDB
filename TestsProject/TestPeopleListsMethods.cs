using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestsProject;

[TestClass]
public class TestPeopleListsMethods
{
	[TestMethod]
	[DoNotParallelize]
	public async Task GetPopularAsync()
	{
		int page = 1;
		string language = "en-US";

		//await ClientFactory.GetClient().Endpoints.PeopleLists.GetPopularAsync(page, language);
	}
}
