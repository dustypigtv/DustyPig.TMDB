using DustyPig.REST;
using DustyPig.TMDB.Enums;
using DustyPig.TMDB.Models.Common;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Clients;

public class GuestSessionsClient
{
    private readonly Client _client;

    internal GuestSessionsClient(Client client) => _client = client;


    public Task<Response<PagedResult<Movie>>> GetRatedMoviesAsync(string guestSessionId, int page = 1, string language = "en-US", SortByCreated sortBy = SortByCreated.CreatedAtAsc, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "language", language },
            { "sort_by", sortBy.GetEnumDescription() }
        };

        return _client.GetAsync<PagedResult<Movie>>($"/3/guest_session/{guestSessionId}/rated/movies", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get the rated TV shows for a guest session.
    /// </summary>
    public Task<Response<PagedResult<TvSeries>>> GetRatedTvSeriesAsync(string guestSessionId, int page = 1, string language = "en-US", SortByCreated sortBy = SortByCreated.CreatedAtAsc, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "language", language },
            { "sort_by", sortBy.GetEnumDescription() }
        };

        return _client.GetAsync<PagedResult<TvSeries>>($"/3/guest_session/{guestSessionId}/rated/tv", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get the rated TV episodes for a guest session.
    /// </summary>
    public Task<Response<PagedResult<RatedTvEpisode>>> GetRatedTvEpisodesAsync(string guestSessionId, int page = 1, string language = "en-US", SortByCreated sortBy = SortByCreated.CreatedAtAsc, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "language", language },
            { "sort_by", sortBy.GetEnumDescription() }
        };

        return _client.GetAsync<PagedResult<RatedTvEpisode>>($"/3/guest_session/{guestSessionId}/rated/tv/episodes", queryParams, cancellationToken);
    }
}
