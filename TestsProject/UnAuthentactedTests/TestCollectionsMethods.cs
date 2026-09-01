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

        var ret = await ClientFactory.GetClient().Endpoints.Collections.GetDetailsAsync(collectionId, language);
        AdditionalPropertiesChecker.Check(ret);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetImages()
    {
        int collectionId = Constants.COLLECTION_ID;
        string includeImageLanguage = null;
        string language = Constants.Language;

        var ret = await ClientFactory.GetClient().Endpoints.Collections.GetImagesAsync(collectionId, includeImageLanguage, language);
        AdditionalPropertiesChecker.Check(ret);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetTranslations()
    {
        int collectionId = Constants.COLLECTION_ID;

        var ret = await ClientFactory.GetClient().Endpoints.Collections.GetTranslationsAsync(collectionId);
        AdditionalPropertiesChecker.Check(ret);
    }
}
