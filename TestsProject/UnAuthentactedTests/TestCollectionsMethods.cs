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
        Assert.IsEmpty(ret.Data.AdditionalProperties);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetImages()
    {
        int collectionId = Constants.COLLECTION_ID;
        string includeImageLanguage = null;
        string language = Constants.Language;

        var ret = await ClientFactory.GetClient().Endpoints.Collections.GetImagesAsync(collectionId, includeImageLanguage, language);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var item in ret.Data.Backdrops)
            Assert.IsEmpty(item.AdditionalProperties);
        foreach (var item in ret.Data.Posters)
            Assert.IsEmpty(item.AdditionalProperties);
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetTranslations()
    {
        int collectionId = Constants.COLLECTION_ID;

        var ret = await ClientFactory.GetClient().Endpoints.Collections.GetTranslationsAsync(collectionId);
        Assert.IsEmpty(ret.Data.AdditionalProperties);
        foreach (var item in ret.Data.Translations)
        {
            Assert.IsEmpty(item.AdditionalProperties);
        }
    }
}
