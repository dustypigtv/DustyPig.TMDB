using DustyPig.TMDB.Interfaces;
using DustyPig.TMDB.Models.Common;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Clients;

internal class KeywordsClient : IKeywords
{
    private readonly Client _client;

    internal KeywordsClient(Client client) => _client = client;


    public Task<Response<CommonName>> GetDetailsAsync(int keywordId, CancellationToken cancellationToken = default) =>
        _client.GetAsync<CommonName>($"/3/keyword/{keywordId}", null, cancellationToken);
}
