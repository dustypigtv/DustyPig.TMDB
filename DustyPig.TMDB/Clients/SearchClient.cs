using DustyPig.REST;
using DustyPig.TMDB.Interfaces;
using DustyPig.TMDB.Models.Common;
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
    public Task<Response<PagedResult<Collection>>> CollectionsAsync(string query, int page = 1, bool? includeAdult = null, string language = "en-US", string region = null, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "query", query },
            { "page", page },
            { "include_adult", includeAdult },
            { "language", language },
            { "region", region }
        };

        return _client.GetAsync<PagedResult<Collection>>("/3/search/collection", queryParams, cancellationToken);
    }

    /// <summary>
    /// Search for companies by their original and alternative names.
    /// </summary>
    public Task<Response<PagedResult<CommonCompany>>> CompaniesAsync(string query, int page = 1, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "query", query },
            { "page", page }
        };

        return _client.GetAsync<PagedResult<CommonCompany>>("/3/search/company", queryParams, cancellationToken);
    }

    /// <summary>
    /// Search for keywords by their name.
    /// </summary>
    public Task<Response<PagedResult<CommonName>>> KeywordsAsync(string query, int page = 1, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "query", query },
            { "page", page }
        };

        return _client.GetAsync<PagedResult<CommonName>>("/3/search/keyword", queryParams, cancellationToken);
    }

    /// <summary>
    /// Search for movies by their original, translated and alternative titles.
    /// </summary>
    public Task<Response<PagedResult<CommonMovie>>> MoviesAsync(string query, int page = 1, bool? includeAdult = null, string language = "en-US", int? primaryReleaseYear = null, string region = null, int? year = null, CancellationToken cancellationToken = default)
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

        return _client.GetAsync<PagedResult<CommonMovie>>("/3/search/movie", queryParams, cancellationToken);
    }

    /// <summary>
    /// Use multi search when you want to search for movies, TV shows and people in a single request.
    /// </summary>
    public Task<Response<PagedResult<MultiObject>>> MultiAsync(string query, int page = 1, bool? includeAdult = null, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "query", query },
            { "page", page },
            { "include_adult", includeAdult },
            { "language", language }
        };

        return _client.GetAsync<PagedResult<MultiObject>>("/3/search/multi", queryParams, cancellationToken);
    }

    /// <summary>
    /// Search for people by their name and also known as names.
    /// </summary>
    public Task<Response<PagedResult<Person>>> PeopleAsync(string query, int page = 1, bool? includeAdult = null, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "query", query },
            { "page", page },
            { "include_adult", includeAdult },
            { "language", language }
        };

        return _client.GetAsync<PagedResult<Person>>("/3/search/person", queryParams, cancellationToken);
    }

    /// <summary>
    /// Search for TV shows by their original, translated and also known as names.
    /// </summary>
    /// <param name="firstAirDateYear">Search only the first air date. Valid values are: 1000..9999</param>
    /// <param name="year">Search the first air date and all episode air dates. Valid values are: 1000..9999</param>
    public Task<Response<PagedResult<CommonTvSeries1>>> TvSeriesAsync(string query, int page = 1, int? firstAirDateYear = null, bool? includeAdult = null, string language = "en-US", int? year = null, CancellationToken cancellationToken = default)
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

        return _client.GetAsync<PagedResult<CommonTvSeries1>>("/3/search/tv", queryParams, cancellationToken);
    }
}
