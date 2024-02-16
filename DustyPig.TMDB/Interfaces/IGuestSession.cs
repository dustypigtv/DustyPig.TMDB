using DustyPig.REST;
using DustyPig.TMDB.Models.GuestSession;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Interfaces;

public interface IGuestSession
{
	/// <summary>
	/// Get the rated movies for a guest session.
	/// </summary>
	public Task<Response<RatedMoviesResponse>> GetRatedMoviesAsync(string guestSessionId, int page = 1, string language = "en-US", Sortby sortBy = Sortby.CreatedAtAsc, CancellationToken cancellationToken = default);

	/// <summary>
	/// Get the rated TV shows for a guest session.
	/// </summary>
	public Task<Response<RatedTvResponse>> GetRatedTvAsync(string guestSessionId, int page = 1, string language = "en-US", Sortby sortBy = Sortby.CreatedAtAsc, CancellationToken cancellationToken = default);

	/// <summary>
	/// Get the rated TV episodes for a guest session.
	/// </summary>
	public Task<Response<RatedTvEpisodesResponse>> GetRatedTvEpisodesAsync(string guestSessionId, int page = 1, string language = "en-US", Sortby sortBy = Sortby.CreatedAtAsc, CancellationToken cancellationToken = default);
}