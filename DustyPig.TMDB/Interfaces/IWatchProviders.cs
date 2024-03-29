using DustyPig.REST;
using DustyPig.TMDB.Models.Common;
using DustyPig.TMDB.Models.WatchProviders;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Interfaces;

public interface IWatchProviders
{
    /// <summary>
    /// Get the list of the countries we have watch provider (OTT/streaming) data for.
    /// </summary>
    public Task<Response<ListResult<CommonCountry1>>> GetAvailableRegionsAsync(string language = "en-US", CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the list of streaming providers we have for movies.
    /// </summary>
    public Task<Response<ListResult<Provider>>> GetMovieProvidersAsync(string language = "en-US", string watchRegion = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the list of streaming providers we have for TV shows.
    /// </summary>
    public Task<Response<ListResult<Provider>>> GetTvSeriesProvidersAsync(string language = "en-US", string watchRegion = null, CancellationToken cancellationToken = default);
}
