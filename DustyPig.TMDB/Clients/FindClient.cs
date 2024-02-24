using DustyPig.TMDB.Interfaces;
using DustyPig.TMDB.Models.Find;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Clients;

internal class FindClient : IFind
{
    private readonly Client _client;

    internal FindClient(Client client) => _client = client;


    /// <summary>
    /// Find data by external ID&#39;s.
    /// </summary>
    public Task<Response<MovieList>> GetByIdAsync(string externalId, Externalsource externalSource, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "external_source", externalSource.GetEnumDescription() },
            { "language", language }
        };

        return _client.GetAsync<MovieList>($"/3/find/{externalId}", queryParams, cancellationToken);
    }
}
