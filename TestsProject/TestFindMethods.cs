using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsProject;

[TestClass]
public class TestFindMethods
{
    [TestMethod]
    [DoNotParallelize]
    public async Task GetByIdAsync()
    {
        //string externalId = ;
        //Externalsource externalSource = ;
        string language = "en-US";

        //await ClientFactory.GetClient().Endpoints.Find.GetByIdAsync(externalId, externalSource, language);
    }
}