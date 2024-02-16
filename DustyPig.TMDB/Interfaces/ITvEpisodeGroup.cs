using DustyPig.REST;
using DustyPig.TMDB.Models.TvEpisodeGroup;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Interfaces;

public interface ITvEpisodeGroup
{
	/// <summary>
	/// Get the details of a TV episode group.
	/// </summary>
	public Task<Response<DetailsResponse>> GetDetailsAsync(string tvEpisodeGroupId, CancellationToken cancellationToken = default);
}
