using DustyPig.REST;
using DustyPig.TMDB.Models.TvEpisodeGroups;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Clients;

public class TvEpisodeGroupsClient
{
    private readonly Client _client;

    internal TvEpisodeGroupsClient(Client client) => _client = client;


    /// <summary>
    /// Get the details of a TV episode group.
    /// </summary>
    public Task<Response<Details>> GetDetailsAsync(string tvEpisodeGroupId, CancellationToken cancellationToken = default) =>
        _client.GetAsync<Details>($"/3/tv/episode_group/{tvEpisodeGroupId}", null, cancellationToken);
}
