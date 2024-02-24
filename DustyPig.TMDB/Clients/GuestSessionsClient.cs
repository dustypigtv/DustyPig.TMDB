using DustyPig.REST;
using DustyPig.TMDB.Interfaces;
using DustyPig.TMDB.Models.Common;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Clients;

internal class GuestSessionsClient : IGuestSessions
{
    private readonly Client _client;

    internal GuestSessionsClient(Client client) => _client = client;


    /// <summary>
    /// Get the rated movies for a guest session.
    /// </summary>
    public Task<Response<PagedResult<CommonRatedMovie>>> GetRatedMoviesAsync(string guestSessionId, int page = 1, string language = "en-US", CommonSortByCreated sortBy = CommonSortByCreated.CreatedAtAsc, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "language", language },
            { "sort_by", sortBy.GetEnumDescription() }
        };

        return _client.GetAsync<PagedResult<CommonRatedMovie>>($"/3/guest_session/{guestSessionId}/rated/movies", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get the rated TV shows for a guest session.
    /// </summary>
    public Task<Response<PagedResult<CommonRatedTvSeries>>> GetRatedTvAsync(string guestSessionId, int page = 1, string language = "en-US", CommonSortByCreated sortBy = CommonSortByCreated.CreatedAtAsc, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "language", language },
            { "sort_by", sortBy.GetEnumDescription() }
        };

        return _client.GetAsync<PagedResult<CommonRatedTvSeries>>($"/3/guest_session/{guestSessionId}/rated/tv", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get the rated TV episodes for a guest session.
    /// </summary>
    public Task<Response<PagedResult<CommonRatedTvEpisode>>> GetRatedTvEpisodesAsync(string guestSessionId, int page = 1, string language = "en-US", CommonSortByCreated sortBy = CommonSortByCreated.CreatedAtAsc, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "language", language },
            { "sort_by", sortBy.GetEnumDescription() }
        };

        return _client.GetAsync<PagedResult<CommonRatedTvEpisode>>($"/3/guest_session/{guestSessionId}/rated/tv/episodes", queryParams, cancellationToken);
    }
}
