using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestsProject;

[TestClass]
public class TestCollectionsMethods
{
	[TestMethod]
	[DoNotParallelize]
	public async Task GetDetailsAsync()
	{
		//int collectionId = ;
		string language = "en-US";

		//await ClientFactory.GetClient().Endpoints.Collections.GetDetailsAsync(collectionId, language);
	}



	[TestMethod]
	[DoNotParallelize]
	public async Task GetImagesAsync()
	{
		//int collectionId = ;
		string includeImageLanguage = null;
		string language = "en-US";

		//await ClientFactory.GetClient().Endpoints.Collections.GetImagesAsync(collectionId, includeImageLanguage, language);
	}



	[TestMethod]
	[DoNotParallelize]
	public async Task GetTranslationsAsync()
	{
		//int collectionId = ;

		//await ClientFactory.GetClient().Endpoints.Collections.GetTranslationsAsync(collectionId);
	}
}
