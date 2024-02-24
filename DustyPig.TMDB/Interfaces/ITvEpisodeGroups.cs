using DustyPig.TMDB.Models.TvEpisodeGroups;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Interfaces;

public interface ITvEpisodeGroups
{
    /// <summary>
    /// Get the details of a TV episode group.
    /// </summary>
    public Task<Response<Details>> GetDetailsAsync(string tvEpisodeGroupId, CancellationToken cancellationToken = default);
}
