using DustyPig.TMDB.Models.Common;
using DustyPig.TMDB.Models.PeopleLists;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Interfaces;

public interface IPeopleLists
{
    /// <summary>
    /// Get a list of people ordered by popularity.
    /// </summary>
    public Task<Response<PagedResult<Popular>>> GetPopularAsync(int page = 1, string language = "en-US", CancellationToken cancellationToken = default);
}