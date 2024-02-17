using DustyPig.REST;
using DustyPig.TMDB.Interfaces;
using DustyPig.TMDB.Models.Keyword;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Clients;

internal class KeywordClient : IKeyword
{
    private readonly Client _client;

    internal KeywordClient(Client client) => _client = client;


    public Task<Response<DetailsResponse>> GetDetailsAsync(int keywordId, CancellationToken cancellationToken = default) =>
        _client.GetAsync<DetailsResponse>($"/3/keyword/{keywordId}", null, cancellationToken);

    public Task<Response<MoviesResponse>> GetMoviesAsync(string keywordId, int page = 1, bool? includeAdult = null, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "include_adult", includeAdult },
            { "language", language }
        };

        return _client.GetAsync<MoviesResponse>($"/3/keyword/{keywordId}/movies", queryParams, cancellationToken);
    }
}
