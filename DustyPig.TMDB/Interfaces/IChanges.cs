using DustyPig.TMDB.Models.Changes;
using DustyPig.TMDB.Models.Common;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Interfaces;

public interface IChanges
{
    /// <summary>
    /// Get a list of all of the movie ids that have been changed in the past 24 hours.
    /// </summary>
    public Task<Response<PagedResult<Changes>>> GetMoviesAsync(int page = 1, DateOnly? endDate = null, DateOnly? startDate = null, CancellationToken cancellationToken = default);

    public Task<Response<PagedResult<Changes>>> GetPeopleAsync(int page = 1, DateOnly? endDate = null, DateOnly? startDate = null, CancellationToken cancellationToken = default);

    public Task<Response<PagedResult<Changes>>> GetTvSeriesAsync(int page = 1, DateOnly? endDate = null, DateOnly? startDate = null, CancellationToken cancellationToken = default);
}
