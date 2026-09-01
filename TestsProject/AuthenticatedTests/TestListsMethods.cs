using DustyPig.TMDB.Models.Lists;

namespace TestsProject.AuthenticatedTests;

[TestClass]
public class TestListsMethods
{
    [TestMethod]
    [DoNotParallelize]
    public async Task TestEverything()
    {
        var client = ClientFactory.GetClient();
        string sessionId = Environment.GetEnvironmentVariable("TMDB_API_SESSION_ID");


        var createRequest = new CreateRequest
        {
            Name = "---TEST-LIST---",
            Description = "Hello World",
            Language = "en-US"
        };
        var createListResponse = await client.Endpoints.Lists.CreateAsync(createRequest, sessionId);
        var listId = createListResponse.Data.ListId;
        var movieId = Constants.MOVIE_ID;

        var ret1 = await client.Endpoints.Lists.AddMovieAsync(movieId, listId, sessionId);
        AdditionalPropertiesChecker.Check(ret1);

        var ret2 = await client.Endpoints.Lists.CheckItemStatusAsync(listId, Constants.Language, Constants.MOVIE_ID);
        AdditionalPropertiesChecker.Check(ret2);

        var ret3 = await client.Endpoints.Lists.GetDetailsAsync(listId, 1, Constants.Language);
        AdditionalPropertiesChecker.Check(ret3);

        var ret4 = await client.Endpoints.Lists.RemoveMovieAsync(movieId, listId, sessionId);
        AdditionalPropertiesChecker.Check(ret4);

        var ret5 = await client.Endpoints.Lists.ClearAsync(listId, true, sessionId);
        AdditionalPropertiesChecker.Check(ret5);

        var ret6 = await client.Endpoints.Lists.DeleteAsync(listId, sessionId);
        AdditionalPropertiesChecker.Check(ret6);
    }
}