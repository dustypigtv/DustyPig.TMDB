using DustyPig.TMDB.Models.Common;
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
    /// <param name="withReleaseANDType">Can only be used if <paramref name="withReleaseORType"/> == null. Possible values are: [1, 2, 3, 4, 5, 6] can be a comma (`AND`) or pipe (`OR`) separated query, can be used in conjunction with `region`</param>
    /// <param name="withReleaseORType">Can only be used if <paramref name="withReleaseANDType"/> == null. Ppossible values are: [1, 2, 3, 4, 5, 6] can be a comma (`AND`) or pipe (`OR`) separated query, can be used in conjunction with `region`</param>
    /// <param name="withWatchMonetizationANDTypes">Can only be used if <paramref name="withWatchMonetizationORTypes"/> == null. Possible values are: [flatrate, free, ads, rent, buy] use in conjunction with `watch_region`, can be a comma (`AND`) or pipe (`OR`) separated query</param>
    /// <param name="withWatchMonetizationORTypes">Can only be used if <paramref name="withWatchMonetizationANDTypes"/> == null. Possible values are: [flatrate, free, ads, rent, buy] use in conjunction with `watch_region`, can be a comma (`AND`) or pipe (`OR`) separated query</param>
    /// <param name="withWatchProviders">use in conjunction with `watch_region`, can be a comma (`AND`) or pipe (`OR`) separated query</param>
    public Task<Response<PagedResult<CommonMovie>>> GetMovieAsync(int page = 1, string certification = null, string certificationCountry = null, string certificationGte = null, string certificationLte = null, bool? includeAdult = null, bool? includeVideo = null, string language = "en-US", DateOnly? primaryReleaseDateGte = null, DateOnly? primaryReleaseDateLte = null, int? primaryReleaseYear = null, string region = null, DateOnly? releaseDateGte = null, DateOnly? releaseDateLte = null, SortMoviesBy sortBy = SortMoviesBy.PopularityDesc, float? voteAverageGte = null, float? voteAverageLte = null, float? voteCountGte = null, float? voteCountLte = null, string watchRegion = null, string withCast = null, string withCompanies = null, string withCrew = null, string withGenres = null, string withKeywords = null, string withOriginalLanguage = null, string withOriginCountry = null, string withoutCompanies = null, string withoutGenres = null, string withoutKeywords = null, string withoutWatchProviders = null, string withPeople = null, MovieReleaseTypes? withReleaseANDType = null, MovieReleaseTypes? withReleaseORType = null, int? withRuntimeGte = null, int? withRuntimeLte = null, WatchMonetizationTypes? withWatchMonetizationANDTypes = null, WatchMonetizationTypes? withWatchMonetizationORTypes = null, string withWatchProviders = null, int? year = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Find TV shows using over 30 filters and sort options.
    /// </summary>
    /// <param name="withCompanies">can be a comma (`AND`) or pipe (`OR`) separated query</param>
    /// <param name="withGenres">can be a comma (`AND`) or pipe (`OR`) separated query</param>
    /// <param name="withKeywords">can be a comma (`AND`) or pipe (`OR`) separated query</param>
    /// <param name="withANDStatus">Can only be used if <paramref name="withORStatus"/> == null. Possible values are: [0, 1, 2, 3, 4, 5], can be a comma (`AND`) or pipe (`OR`) separated query</param>
    /// <param name="withORStatus">Can only be used if <paramref name="withANDStatus"/> == null. Possible values are: [0, 1, 2, 3, 4, 5], can be a comma (`AND`) or pipe (`OR`) separated query</param>
    /// <param name="withANDType">Can only be used if <paramref name="withORType"/> == null. Possible values are: [0, 1, 2, 3, 4, 5, 6], can be a comma (`AND`) or pipe (`OR`) separated query</param>
    /// <param name="withORType">Can only be used if <paramref name="withANDType"/> == null. Possible values are: [0, 1, 2, 3, 4, 5, 6], can be a comma (`AND`) or pipe (`OR`) separated query</param>
    /// <param name="withWatchMonetizationANDTypes">Can only be used if <paramref name="withWatchMonetizationORTypes"/> == null. Possible values are: [flatrate, free, ads, rent, buy] use in conjunction with `watch_region`, can be a comma (`AND`) or pipe (`OR`) separated query</param>
    /// <param name="withWatchMonetizationORTypes">Can only be used if <paramref name="withWatchMonetizationANDTypes"/> == null. Possible values are: [flatrate, free, ads, rent, buy] use in conjunction with `watch_region`, can be a comma (`AND`) or pipe (`OR`) separated query</param>
    /// <param name="withWatchProviders">use in conjunction with `watch_region`, can be a comma (`AND`) or pipe (`OR`) separated query</param>
    public Task<Response<PagedResult<CommonTvSeries2>>> GetTvAsync(int page = 1, DateOnly? airDateGte = null, DateOnly? airDateLte = null, DateOnly? firstAirDateGte = null, DateOnly? firstAirDateLte = null, int? firstAirDateYear = null, bool? includeAdult = null, bool? includeNullFirstAirDates = null, string language = "en-US", bool? screenedTheatrically = null, SortTvSeriesBy sortBy = SortTvSeriesBy.PopularityDesc, string timezone = null, float? voteAverageGte = null, float? voteAverageLte = null, float? voteCountGte = null, float? voteCountLte = null, string watchRegion = null, string withCompanies = null, string withGenres = null, string withKeywords = null, int? withNetworks = null, string withOriginalLanguage = null, string withOriginCountry = null, string withoutCompanies = null, string withoutGenres = null, string withoutKeywords = null, string withoutWatchProviders = null, int? withRuntimeGte = null, int? withRuntimeLte = null, TvSeriesStatus? withANDStatus = null, TvSeriesStatus? withORStatus = null, CommonTvSeriesTypes? withANDType = null, CommonTvSeriesTypes? withORType = null, WatchMonetizationTypes? withWatchMonetizationANDTypes = null, WatchMonetizationTypes? withWatchMonetizationORTypes = null, string withWatchProviders = null, CancellationToken cancellationToken = default);
}
