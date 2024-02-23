using DustyPig.REST;
using DustyPig.TMDB.Models.Discover;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Interfaces;

public interface IDiscover
{
    /// <summary>
    /// Find movies using over 30 filters and sort options.
    /// </summary>
    /// <param name="certification">use in conjunction with `region`</param>
    /// <param name="certificationCountry">use in conjunction with the `certification`, `certification.gte` and `certification.lte` filters</param>
    /// <param name="certificationGte">use in conjunction with `region`</param>
    /// <param name="certificationLte">use in conjunction with `region`</param>
    /// <param name="withCast">can be a comma (`AND`) or pipe (`OR`) separated query</param>
    /// <param name="withCompanies">can be a comma (`AND`) or pipe (`OR`) separated query</param>
    /// <param name="withCrew">can be a comma (`AND`) or pipe (`OR`) separated query</param>
    /// <param name="withGenres">can be a comma (`AND`) or pipe (`OR`) separated query</param>
    /// <param name="withKeywords">can be a comma (`AND`) or pipe (`OR`) separated query</param>
    /// <param name="withPeople">can be a comma (`AND`) or pipe (`OR`) separated query</param>
    /// <param name="withReleaseType">possible values are: [1, 2, 3, 4, 5, 6] can be a comma (`AND`) or pipe (`OR`) separated query, can be used in conjunction with `region`</param>
    /// <param name="withWatchMonetizationTypes">possible values are: [flatrate, free, ads, rent, buy] use in conjunction with `watch_region`, can be a comma (`AND`) or pipe (`OR`) separated query</param>
    /// <param name="withWatchProviders">use in conjunction with `watch_region`, can be a comma (`AND`) or pipe (`OR`) separated query</param>
    public Task<Response<MovieResponse>> GetMovieAsync(int page = 1, string certification = null, string certificationCountry = null, string certificationGte = null, string certificationLte = null, bool? includeAdult = null, bool? includeVideo = null, string language = "en-US", DateOnly? primaryReleaseDateGte = null, DateOnly? primaryReleaseDateLte = null, int? primaryReleaseYear = null, string region = null, DateOnly? releaseDateGte = null, DateOnly? releaseDateLte = null, Sortby sortBy = Sortby.PopularityDesc, float? voteAverageGte = null, float? voteAverageLte = null, float? voteCountGte = null, float? voteCountLte = null, string watchRegion = null, string withCast = null, string withCompanies = null, string withCrew = null, string withGenres = null, string withKeywords = null, string withOriginalLanguage = null, string withOriginCountry = null, string withoutCompanies = null, string withoutGenres = null, string withoutKeywords = null, string withoutWatchProviders = null, string withPeople = null, int? withReleaseType = null, int? withRuntimeGte = null, int? withRuntimeLte = null, string withWatchMonetizationTypes = null, string withWatchProviders = null, int? year = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Find TV shows using over 30 filters and sort options.
    /// </summary>
    /// <param name="withCompanies">can be a comma (`AND`) or pipe (`OR`) separated query</param>
    /// <param name="withGenres">can be a comma (`AND`) or pipe (`OR`) separated query</param>
    /// <param name="withKeywords">can be a comma (`AND`) or pipe (`OR`) separated query</param>
    /// <param name="withStatus">possible values are: [0, 1, 2, 3, 4, 5], can be a comma (`AND`) or pipe (`OR`) separated query</param>
    /// <param name="withType">possible values are: [0, 1, 2, 3, 4, 5, 6], can be a comma (`AND`) or pipe (`OR`) separated query</param>
    /// <param name="withWatchMonetizationTypes">possible values are: [flatrate, free, ads, rent, buy] use in conjunction with `watch_region`, can be a comma (`AND`) or pipe (`OR`) separated query</param>
    /// <param name="withWatchProviders">use in conjunction with `watch_region`, can be a comma (`AND`) or pipe (`OR`) separated query</param>
    public Task<Response<TvResponse>> GetTvAsync(int page = 1, DateOnly? airDateGte = null, DateOnly? airDateLte = null, DateOnly? firstAirDateGte = null, DateOnly? firstAirDateLte = null, int? firstAirDateYear = null, bool? includeAdult = null, bool? includeNullFirstAirDates = null, string language = "en-US", bool? screenedTheatrically = null, Sortby2 sortBy = Sortby2.PopularityDesc, string timezone = null, float? voteAverageGte = null, float? voteAverageLte = null, float? voteCountGte = null, float? voteCountLte = null, string watchRegion = null, string withCompanies = null, string withGenres = null, string withKeywords = null, int? withNetworks = null, string withOriginalLanguage = null, string withOriginCountry = null, string withoutCompanies = null, string withoutGenres = null, string withoutKeywords = null, string withoutWatchProviders = null, int? withRuntimeGte = null, int? withRuntimeLte = null, string withStatus = null, string withType = null, string withWatchMonetizationTypes = null, string withWatchProviders = null, CancellationToken cancellationToken = default);
}
