using DustyPig.REST;
using DustyPig.TMDB.Interfaces;
using DustyPig.TMDB.Models.Search;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Clients;

internal class SearchClient : ISearch
{
	private readonly Client _client;

	internal SearchClient(Client client) => _client = client;


	/// <summary>
	/// Search for collections by their original, translated and alternative names.
	/// </summary>
	public Task<Response<CollectionResponse>> GetCollectionAsync(string query, int page = 1, bool? includeAdult = null, string language = "en-US", string region = null, CancellationToken cancellationToken = default)
	{
		var queryParams = new Dictionary<string, object>
		{
			{ "query", query },
			{ "page", page },
			{ "include_adult", includeAdult },
			{ "language", language },
			{ "region", region }
		};

		return _client.GetAsync<CollectionResponse>("/3/search/collection", queryParams, cancellationToken);
	}

	/// <summary>
	/// Search for companies by their original and alternative names.
	/// </summary>
	public Task<Response<CompanyResponse>> GetCompanyAsync(string query, int page = 1, CancellationToken cancellationToken = default)
	{
		var queryParams = new Dictionary<string, object>
		{
			{ "query", query },
			{ "page", page }
		};

		return _client.GetAsync<CompanyResponse>("/3/search/company", queryParams, cancellationToken);
	}

	/// <summary>
	/// Search for keywords by their name.
	/// </summary>
	public Task<Response<KeywordResponse>> GetKeywordAsync(string query, int page = 1, CancellationToken cancellationToken = default)
	{
		var queryParams = new Dictionary<string, object>
		{
			{ "query", query },
			{ "page", page }
		};

		return _client.GetAsync<KeywordResponse>("/3/search/keyword", queryParams, cancellationToken);
	}

	/// <summary>
	/// Search for movies by their original, translated and alternative titles.
	/// </summary>
	public Task<Response<MovieResponse>> GetMovieAsync(string query, int page = 1, bool? includeAdult = null, string language = "en-US", int? primaryReleaseYear = null, string region = null, int? year = null, CancellationToken cancellationToken = default)
	{
		var queryParams = new Dictionary<string, object>
		{
			{ "query", query },
			{ "page", page },
			{ "include_adult", includeAdult },
			{ "language", language },
			{ "primary_release_year", primaryReleaseYear },
			{ "region", region },
			{ "year", year }
		};

		return _client.GetAsync<MovieResponse>("/3/search/movie", queryParams, cancellationToken);
	}

	/// <summary>
	/// Use multi search when you want to search for movies, TV shows and people in a single request.
	/// </summary>
	public Task<Response<MultiResponse>> GetMultiAsync(string query, int page = 1, bool? includeAdult = null, string language = "en-US", CancellationToken cancellationToken = default)
	{
		var queryParams = new Dictionary<string, object>
		{
			{ "query", query },
			{ "page", page },
			{ "include_adult", includeAdult },
			{ "language", language }
		};

		return _client.GetAsync<MultiResponse>("/3/search/multi", queryParams, cancellationToken);
	}

	/// <summary>
	/// Search for people by their name and also known as names.
	/// </summary>
	public Task<Response<PersonResponse>> GetPersonAsync(string query, int page = 1, bool? includeAdult = null, string language = "en-US", CancellationToken cancellationToken = default)
	{
		var queryParams = new Dictionary<string, object>
		{
			{ "query", query },
			{ "page", page },
			{ "include_adult", includeAdult },
			{ "language", language }
		};

		return _client.GetAsync<PersonResponse>("/3/search/person", queryParams, cancellationToken);
	}

	/// <summary>
	/// Search for TV shows by their original, translated and also known as names.
	/// </summary>
	/// <param name="firstAirDateYear">Search only the first air date. Valid values are: 1000..9999</param>
	/// <param name="year">Search the first air date and all episode air dates. Valid values are: 1000..9999</param>
	public Task<Response<TvResponse>> GetTvAsync(string query, int page = 1, int? firstAirDateYear = null, bool? includeAdult = null, string language = "en-US", int? year = null, CancellationToken cancellationToken = default)
	{
		var queryParams = new Dictionary<string, object>
		{
			{ "query", query },
			{ "page", page },
			{ "first_air_date_year", firstAirDateYear },
			{ "include_adult", includeAdult },
			{ "language", language },
			{ "year", year }
		};

		return _client.GetAsync<TvResponse>("/3/search/tv", queryParams, cancellationToken);
	}
}