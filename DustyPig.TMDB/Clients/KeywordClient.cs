using DustyPig.REST;
using DustyPig.TMDB.Interfaces;
using DustyPig.TMDB.Models;
using DustyPig.TMDB.Models.Common;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Clients;

internal class KeywordClient : IKeyword
{
    private readonly Client _client;

    internal KeywordClient(Client client) => _client = client;


    public Task<Response<NameObject>> GetDetailsAsync(int keywordId, CancellationToken cancellationToken = default) =>
        _client.GetAsync<NameObject>($"/3/keyword/{keywordId}", null, cancellationToken);
}
