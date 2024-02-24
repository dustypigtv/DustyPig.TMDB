using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsProject;

[TestClass]
public class TestCollectionsMethods
{


    [TestMethod]
    [DoNotParallelize]
    public async Task GetDetailsAsync()
    {
        int collectionId = Constants.COLLECTION_ID;
        string language = "en-US";

        await ClientFactory.GetClient().Endpoints.Collections.GetDetailsAsync(collectionId, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetImagesAsync()
    {
        int collectionId = Constants.COLLECTION_ID;
        string includeImageLanguage = null;
        string language = "en-US";

        await ClientFactory.GetClient().Endpoints.Collections.GetImagesAsync(collectionId, includeImageLanguage, language);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetTranslationsAsync()
    {
        int collectionId = Constants.COLLECTION_ID;

        await ClientFactory.GetClient().Endpoints.Collections.GetTranslationsAsync(collectionId);
    }
}
