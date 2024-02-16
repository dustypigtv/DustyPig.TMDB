using DustyPig.REST;
using DustyPig.TMDB.Interfaces;
using DustyPig.TMDB.Models.WatchProviders;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Clients;

internal class WatchProvidersClient : IWatchProviders
{
	private readonly Client _client;

	internal WatchProvidersClient(Client client) => _client = client;


	/// <summary>
	/// Get the list of the countries we have watch provider (OTT/streaming) data for.
	/// </summary>
	public Task<Response<AvailableRegionsResponse>> GetAvailableRegionsAsync(string language = "en-US", CancellationToken cancellationToken = default)
	{
		var queryParams = new Dictionary<string, object>
		{
			{ "language", language }
		};

		return _client.GetAsync<AvailableRegionsResponse>("/3/watch/providers/regions", queryParams, cancellationToken);
	}

	/// <summary>
	/// Get the list of streaming providers we have for movies.
	/// </summary>
	public Task<Response<MovieProvidersResponse>> GetMovieProvidersAsync(string language = "en-US", string watchRegion = null, CancellationToken cancellationToken = default)
	{
		var queryParams = new Dictionary<string, object>
		{
			{ "language", language },
			{ "watch_region", watchRegion }
		};

		return _client.GetAsync<MovieProvidersResponse>("/3/watch/providers/movie", queryParams, cancellationToken);
	}

	/// <summary>
	/// Get the list of streaming providers we have for TV shows.
	/// </summary>
	public Task<Response<TvProvidersResponse>> GetTvProvidersAsync(string language = "en-US", string watchRegion = null, CancellationToken cancellationToken = default)
	{
		var queryParams = new Dictionary<string, object>
		{
			{ "language", language },
			{ "watch_region", watchRegion }
		};

		return _client.GetAsync<TvProvidersResponse>("/3/watch/providers/tv", queryParams, cancellationToken);
	}
}
