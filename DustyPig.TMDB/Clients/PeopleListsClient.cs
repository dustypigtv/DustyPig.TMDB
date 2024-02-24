using DustyPig.TMDB.Interfaces;
using DustyPig.TMDB.Models.Common;
using DustyPig.TMDB.Models.PeopleLists;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Clients;

internal class PeopleListsClient : IPeopleLists
{
    private readonly Client _client;

    internal PeopleListsClient(Client client) => _client = client;


    /// <summary>
    /// Get a list of people ordered by popularity.
    /// </summary>
    public Task<Response<PagedResult<Popular>>> GetPopularAsync(int page = 1, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "language", language }
        };

        return _client.GetAsync<PagedResult<Popular>>("/3/person/popular", queryParams, cancellationToken);
    }

}