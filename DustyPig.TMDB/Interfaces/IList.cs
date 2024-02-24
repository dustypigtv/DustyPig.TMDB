using DustyPig.REST;
using DustyPig.TMDB.Models.Common;
using DustyPig.TMDB.Models.List;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Interfaces;

public interface IList
{
    /// <summary>
    /// Add a movie to a list.
    /// </summary>
    public Task<Response<StatusResponse>> AddMovieAsync(MediaIdRequest postData, int listId, string sessionId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Use this method to check if an item has already been added to the list.
    /// </summary>
    public Task<Response<CheckItemStatusResponse>> GetCheckItemStatusAsync(int listId, string language = "en-US", int? movieId = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Clear all items from a list.
    /// </summary>
    public Task<Response<StatusResponse>> ClearAsync(int listId, bool confirm, string sessionId, CancellationToken cancellationToken = default);

    public Task<Response<CreateResponse>> CreateAsync(CreateRequest postData, string sessionId, CancellationToken cancellationToken = default);

    public Task<Response<DetailsResponse>> GetDetailsAsync(int listId, int page = 1, string language = "en-US", CancellationToken cancellationToken = default);

    /// <summary>
    /// Remove a movie from a list.
    /// </summary>
    public Task<Response<StatusResponse>> RemoveMovieAsync(MediaIdRequest postData, int listId, string sessionId, CancellationToken cancellationToken = default);
}
