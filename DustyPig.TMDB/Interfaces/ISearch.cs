using DustyPig.REST;
using DustyPig.TMDB.Models.Common;
using DustyPig.TMDB.Models.Search;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Interfaces;

public interface ISearch
{
    /// <summary>
    /// Search for collections by their original, translated and alternative names.
    /// </summary>
    public Task<Response<PagedResult<CollectionResponse>>> GetCollectionAsync(string query, int page = 1, bool? includeAdult = null, string language = "en-US", string region = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Search for companies by their original and alternative names.
    /// </summary>
    public Task<Response<PagedResult<CompanyObject>>> GetCompanyAsync(string query, int page = 1, CancellationToken cancellationToken = default);

    /// <summary>
    /// Search for keywords by their name.
    /// </summary>
    public Task<Response<PagedResult<NameObject>>> GetKeywordAsync(string query, int page = 1, CancellationToken cancellationToken = default);

    /// <summary>
    /// Search for movies by their original, translated and alternative titles.
    /// </summary>
    public Task<Response<PagedResult<MovieObject>>> GetMovieAsync(string query, int page = 1, bool? includeAdult = null, string language = "en-US", int? primaryReleaseYear = null, string region = null, int? year = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Use multi search when you want to search for movies, TV shows and people in a single request.
    /// </summary>
    public Task<Response<PagedResult<MultiResponse>>> GetMultiAsync(string query, int page = 1, bool? includeAdult = null, string language = "en-US", CancellationToken cancellationToken = default);

    /// <summary>
    /// Search for people by their name and also known as names.
    /// </summary>
    public Task<Response<PagedResult<PersonResponse>>> GetPersonAsync(string query, int page = 1, bool? includeAdult = null, string language = "en-US", CancellationToken cancellationToken = default);

    /// <summary>
    /// Search for TV shows by their original, translated and also known as names.
    /// </summary>
    /// <param name="firstAirDateYear">Search only the first air date. Valid values are: 1000..9999</param>
    /// <param name="year">Search the first air date and all episode air dates. Valid values are: 1000..9999</param>
    public Task<Response<PagedResult<Models.Common.TvSeriesResponse>>> GetTvAsync(string query, int page = 1, int? firstAirDateYear = null, bool? includeAdult = null, string language = "en-US", int? year = null, CancellationToken cancellationToken = default);
}
