using DustyPig.TMDB.Models.Find;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsProject.UnAuthentactedTests;

[TestClass]
public class TestFindMethods
{
    [TestMethod]
    [DoNotParallelize]
    public async Task GetById()
    {
        string externalId = "tt0848228";
        Externalsource externalSource = Externalsource.ImdbId;
        string language = Constants.Language;

        await ClientFactory.GetClient().Endpoints.Find.GetByIdAsync(externalId, externalSource, language);
    }
}
