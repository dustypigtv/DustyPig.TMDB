using DustyPig.REST;
using DustyPig.TMDB.Interfaces;
using DustyPig.TMDB.Models.Common;
using DustyPig.TMDB.Models.GuestSession;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Clients;

internal class GuestSessionClient : IGuestSession
{
    private readonly Client _client;

    internal GuestSessionClient(Client client) => _client = client;


    /// <summary>
    /// Get the rated movies for a guest session.
    /// </summary>
    public Task<Response<PagedResult<RatedMoviesResponse>>> GetRatedMoviesAsync(string guestSessionId, int page = 1, string language = "en-US", Sortby sortBy = Sortby.CreatedAtAsc, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "language", language },
            { "sort_by", sortBy.GetEnumDescription() }
        };

        return _client.GetAsync<PagedResult<RatedMoviesResponse>>($"/3/guest_session/{guestSessionId}/rated/movies", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get the rated TV shows for a guest session.
    /// </summary>
    public Task<Response<PagedResult<RatedTvResponse>>> GetRatedTvAsync(string guestSessionId, int page = 1, string language = "en-US", Sortby sortBy = Sortby.CreatedAtAsc, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "language", language },
            { "sort_by", sortBy.GetEnumDescription() }
        };

        return _client.GetAsync<PagedResult<RatedTvResponse>>($"/3/guest_session/{guestSessionId}/rated/tv", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get the rated TV episodes for a guest session.
    /// </summary>
    public Task<Response<PagedResult<RatedTvEpisodesResponse>>> GetRatedTvEpisodesAsync(string guestSessionId, int page = 1, string language = "en-US", Sortby sortBy = Sortby.CreatedAtAsc, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "language", language },
            { "sort_by", sortBy.GetEnumDescription() }
        };

        return _client.GetAsync<PagedResult<RatedTvEpisodesResponse>>($"/3/guest_session/{guestSessionId}/rated/tv/episodes", queryParams, cancellationToken);
    }
}
