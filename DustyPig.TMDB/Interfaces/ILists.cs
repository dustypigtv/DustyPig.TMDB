using DustyPig.TMDB.Models.Common;
using DustyPig.TMDB.Models.Lists;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Interfaces;

public interface ILists
{
    /// <summary>
    /// Add a movie to a list.
    /// </summary>
    public Task<Response<CommonStatus>> AddMovieAsync(MediaIdObject postData, int listId, string sessionId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Use this method to check if an item has already been added to the list.
    /// </summary>
    public Task<Response<ItemStatus>> CheckItemStatusAsync(int listId, string language = "en-US", int? movieId = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Clear all items from a list.
    /// </summary>
    public Task<Response<CommonStatus>> ClearAsync(int listId, bool confirm, string sessionId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a list.
    /// </summary>
    public Task<Response<CommonStatus>> DeleteAsync(int listId, string sessionId, CancellationToken cancellationToken = default);

    public Task<Response<CreateResponse>> CreateAsync(CreateRequest postData, string sessionId, CancellationToken cancellationToken = default);

    public Task<Response<Details>> GetDetailsAsync(int listId, int page = 1, string language = "en-US", CancellationToken cancellationToken = default);

    /// <summary>
    /// Remove a movie from a list.
    /// </summary>
    public Task<Response<CommonStatus>> RemoveMovieAsync(MediaIdObject postData, int listId, string sessionId, CancellationToken cancellationToken = default);
}
