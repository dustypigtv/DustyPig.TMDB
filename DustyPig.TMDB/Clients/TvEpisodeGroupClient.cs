using DustyPig.REST;
using DustyPig.TMDB.Interfaces;
using DustyPig.TMDB.Models.TvEpisodeGroup;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Clients;

internal class TvEpisodeGroupClient : ITvEpisodeGroup
{
    private readonly Client _client;

    internal TvEpisodeGroupClient(Client client) => _client = client;


    /// <summary>
    /// Get the details of a TV episode group.
    /// </summary>
    public Task<Response<DetailsResponse>> GetDetailsAsync(string tvEpisodeGroupId, CancellationToken cancellationToken = default) =>
        _client.GetAsync<DetailsResponse>($"/3/tv/episode_group/{tvEpisodeGroupId}", null, cancellationToken);
}
