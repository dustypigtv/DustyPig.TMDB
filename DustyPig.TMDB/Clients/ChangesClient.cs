using DustyPig.TMDB.Interfaces;
using DustyPig.TMDB.Models.Changes;
using DustyPig.TMDB.Models.Common;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Clients;

internal class ChangesClient : IChanges
{
    private readonly Client _client;

    internal ChangesClient(Client client) => _client = client;


    /// <summary>
    /// Get a list of all of the movie ids that have been changed in the past 24 hours.
    /// </summary>
    public Task<Response<PagedResult<Changes>>> GetMovieListAsync(int page = 1, DateOnly? endDate = null, DateOnly? startDate = null, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "end_date", endDate.DateOnlyToTmdb() },
            { "start_date", startDate.DateOnlyToTmdb() }
        };

        return _client.GetAsync<PagedResult<Changes>>("/3/movie/changes", queryParams, cancellationToken);
    }

    public Task<Response<PagedResult<Changes>>> GetPeopleListAsync(int page = 1, DateOnly? endDate = null, DateOnly? startDate = null, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "end_date", endDate.DateOnlyToTmdb() },
            { "start_date", startDate.DateOnlyToTmdb() }
        };

        return _client.GetAsync<PagedResult<Changes>>("/3/person/changes", queryParams, cancellationToken);
    }

    public Task<Response<PagedResult<Changes>>> GetTvListAsync(int page = 1, DateOnly? endDate = null, DateOnly? startDate = null, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "end_date", endDate.DateOnlyToTmdb() },
            { "start_date", startDate.DateOnlyToTmdb() }
        };

        return _client.GetAsync<PagedResult<Changes>>("/3/tv/changes", queryParams, cancellationToken);
    }
}
