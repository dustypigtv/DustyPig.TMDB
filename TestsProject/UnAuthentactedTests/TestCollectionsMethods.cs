using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsProject.UnAuthentactedTests;

[TestClass]
public class TestCollectionsMethods
{
    [TestMethod]
    [DoNotParallelize]
    public async Task GetDetails()
    {
        int collectionId = Constants.COLLECTION_ID;
        string language = Constants.Language;

        await ClientFactory.GetClient().Endpoints.Collections.GetDetailsAsync(collectionId, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetImages()
    {
        int collectionId = Constants.COLLECTION_ID;
        string includeImageLanguage = null;
        string language = Constants.Language;

        await ClientFactory.GetClient().Endpoints.Collections.GetImagesAsync(collectionId, includeImageLanguage, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetTranslations()
    {
        int collectionId = Constants.COLLECTION_ID;

        await ClientFactory.GetClient().Endpoints.Collections.GetTranslationsAsync(collectionId);
    }
}
