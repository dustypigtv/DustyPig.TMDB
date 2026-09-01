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
        Assert.IsEmpty(ret1.Data.AdditionalProperties);

        var ret2 = await client.Endpoints.Lists.CheckItemStatusAsync(listId, Constants.Language, Constants.MOVIE_ID);
        Assert.IsEmpty(ret2.Data.AdditionalProperties);

        var ret3 = await client.Endpoints.Lists.GetDetailsAsync(listId, 1, Constants.Language);
        Assert.IsEmpty(ret3.Data.AdditionalProperties);
        foreach (var item in ret3.Data.Movies)
            Assert.IsEmpty(item.AdditionalProperties);
        foreach (var item in ret3.Data.TvSeries)
            Assert.IsEmpty(item.AdditionalProperties);

        var ret4 = await client.Endpoints.Lists.RemoveMovieAsync(movieId, listId, sessionId);
        Assert.IsEmpty(ret4.Data.AdditionalProperties);

        var ret5 = await client.Endpoints.Lists.ClearAsync(listId, true, sessionId);
        Assert.IsEmpty(ret5.Data.AdditionalProperties);

        var ret6 = await client.Endpoints.Lists.DeleteAsync(listId, sessionId);
        Assert.IsEmpty(ret6.Data.AdditionalProperties);
    }
}