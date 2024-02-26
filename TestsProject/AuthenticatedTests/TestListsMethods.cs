using DustyPig.TMDB.Models.Lists;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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


        var mediaObjectId = new MediaIdObject
        {
            MediaId = Constants.MOVIE_ID
        };

        await client.Endpoints.Lists.AddMovieAsync(mediaObjectId, listId, sessionId);
        await client.Endpoints.Lists.CheckItemStatusAsync(listId, Constants.Language, Constants.MOVIE_ID);
        await client.Endpoints.Lists.GetDetailsAsync(listId, 1, Constants.Language);
        await client.Endpoints.Lists.RemoveMovieAsync(mediaObjectId, listId, sessionId);
        await client.Endpoints.Lists.ClearAsync(listId, true, sessionId);
    }
}