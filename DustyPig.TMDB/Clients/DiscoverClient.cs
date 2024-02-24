using DustyPig.TMDB.Interfaces;
using DustyPig.TMDB.Models.Common;
using DustyPig.TMDB.Models.Discover;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Clients;

internal class DiscoverClient : IDiscover
{
    private readonly Client _client;

    internal DiscoverClient(Client client) => _client = client;


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
    public Task<Response<PagedResult<CommonMovie>>> GetMovieAsync(int page = 1, string certification = null, string certificationCountry = null, string certificationGte = null, string certificationLte = null, bool? includeAdult = null, bool? includeVideo = null, string language = "en-US", DateOnly? primaryReleaseDateGte = null, DateOnly? primaryReleaseDateLte = null, int? primaryReleaseYear = null, string region = null, DateOnly? releaseDateGte = null, DateOnly? releaseDateLte = null, SortMoviesBy sortBy = SortMoviesBy.PopularityDesc, float? voteAverageGte = null, float? voteAverageLte = null, float? voteCountGte = null, float? voteCountLte = null, string watchRegion = null, string withCast = null, string withCompanies = null, string withCrew = null, string withGenres = null, string withKeywords = null, string withOriginalLanguage = null, string withOriginCountry = null, string withoutCompanies = null, string withoutGenres = null, string withoutKeywords = null, string withoutWatchProviders = null, string withPeople = null, MovieReleaseTypes? withReleaseANDType = null, MovieReleaseTypes? withReleaseORType = null, int? withRuntimeGte = null, int? withRuntimeLte = null, WatchMonetizationTypes? withWatchMonetizationANDTypes = null, WatchMonetizationTypes? withWatchMonetizationORTypes = null, string withWatchProviders = null, int? year = null, CancellationToken cancellationToken = default)
    {
        if (withWatchMonetizationANDTypes != null && withWatchMonetizationORTypes != null)
            throw new ArgumentException($"Cannot set both {nameof(withWatchMonetizationANDTypes)} and {nameof(withWatchMonetizationORTypes)}");
        string monetizationTypes = withWatchMonetizationANDTypes?.GetEnumDescription() ?? withWatchMonetizationORTypes?.GetEnumDescription().Replace(',', '|');

        if (withReleaseANDType != null && withReleaseORType != null)
            throw new ArgumentException($"Cannot set both {nameof(withReleaseANDType)} and {nameof(withReleaseORType)}");
        string releaseTypes = withReleaseANDType?.GetEnumDescription() ?? withReleaseORType?.GetEnumDescription().Replace(',', '|');

        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "certification", certification },
            { "certification_country", certificationCountry },
            { "certification.gte", certificationGte },
            { "certification.lte", certificationLte },
            { "include_adult", includeAdult },
            { "include_video", includeVideo },
            { "language", language },
            { "primary_release_date.gte", primaryReleaseDateGte.DateOnlyToTmdb() },
            { "primary_release_date.lte", primaryReleaseDateLte.DateOnlyToTmdb() },
            { "primary_release_year", primaryReleaseYear },
            { "region", region },
            { "release_date.gte", releaseDateGte.DateOnlyToTmdb() },
            { "release_date.lte", releaseDateLte.DateOnlyToTmdb() },
            { "sort_by", sortBy.GetEnumDescription() },
            { "vote_average.gte", voteAverageGte },
            { "vote_average.lte", voteAverageLte },
            { "vote_count.gte", voteCountGte },
            { "vote_count.lte", voteCountLte },
            { "watch_region", watchRegion },
            { "with_cast", withCast },
            { "with_companies", withCompanies },
            { "with_crew", withCrew },
            { "with_genres", withGenres },
            { "with_keywords", withKeywords },
            { "with_original_language", withOriginalLanguage },
            { "with_origin_country", withOriginCountry },
            { "without_companies", withoutCompanies },
            { "without_genres", withoutGenres },
            { "without_keywords", withoutKeywords },
            { "without_watch_providers", withoutWatchProviders },
            { "with_people", withPeople },
            { "with_release_type", releaseTypes },
            { "with_runtime.gte", withRuntimeGte },
            { "with_runtime.lte", withRuntimeLte },
            { "with_watch_monetization_types", monetizationTypes },
            { "with_watch_providers", withWatchProviders },
            { "year", year }
        };

        return _client.GetAsync<PagedResult<CommonMovie>>("/3/discover/movie", queryParams, cancellationToken);
    }

    /// <summary>
    /// Find TV shows using over 30 filters and sort options.
    /// </summary>
    /// <param name="withCompanies">can be a comma (`AND`) or pipe (`OR`) separated query</param>
    /// <param name="withGenres">can be a comma (`AND`) or pipe (`OR`) separated query</param>
    /// <param name="withKeywords">can be a comma (`AND`) or pipe (`OR`) separated query</param>
    /// <param name="withANDStatus">Can only be used if <paramref name="withORStatus"/> == null. Possible values are: [0, 1, 2, 3, 4, 5], can be a comma (`AND`) or pipe (`OR`) separated query</param>
    /// <param name="withORStatus">Can only be used if <paramref name="withANDStatus"/> == null. Possible values are: [0, 1, 2, 3, 4, 5], can be a comma (`AND`) or pipe (`OR`) separated query</param>
    /// <param name="withType">possible values are: [0, 1, 2, 3, 4, 5, 6], can be a comma (`AND`) or pipe (`OR`) separated query</param>
    /// <param name="withWatchMonetizationANDTypes">Can only be used if <paramref name="withWatchMonetizationORTypes"/> == null. Possible values are: [flatrate, free, ads, rent, buy] use in conjunction with `watch_region`, can be a comma (`AND`) or pipe (`OR`) separated query</param>
    /// <param name="withWatchMonetizationORTypes">Can only be used if <paramref name="withWatchMonetizationANDTypes"/> == null. Possible values are: [flatrate, free, ads, rent, buy] use in conjunction with `watch_region`, can be a comma (`AND`) or pipe (`OR`) separated query</param>
    /// <param name="withWatchProviders">use in conjunction with `watch_region`, can be a comma (`AND`) or pipe (`OR`) separated query</param>
    public Task<Response<PagedResult<CommonTvSeries2>>> GetTvAsync(int page = 1, DateOnly? airDateGte = null, DateOnly? airDateLte = null, DateOnly? firstAirDateGte = null, DateOnly? firstAirDateLte = null, int? firstAirDateYear = null, bool? includeAdult = null, bool? includeNullFirstAirDates = null, string language = "en-US", bool? screenedTheatrically = null, SortTvSeriesBy sortBy = SortTvSeriesBy.PopularityDesc, string timezone = null, float? voteAverageGte = null, float? voteAverageLte = null, float? voteCountGte = null, float? voteCountLte = null, string watchRegion = null, string withCompanies = null, string withGenres = null, string withKeywords = null, int? withNetworks = null, string withOriginalLanguage = null, string withOriginCountry = null, string withoutCompanies = null, string withoutGenres = null, string withoutKeywords = null, string withoutWatchProviders = null, int? withRuntimeGte = null, int? withRuntimeLte = null, TvSeriesStatus? withANDStatus = null, TvSeriesStatus? withORStatus = null, string withType = null, WatchMonetizationTypes? withWatchMonetizationANDTypes = null, WatchMonetizationTypes? withWatchMonetizationORTypes = null, string withWatchProviders = null, CancellationToken cancellationToken = default)
    {
        if (withANDStatus != null && withORStatus != null)
            throw new ArgumentException($"Cannot set both {nameof(withANDStatus)} and {nameof(withORStatus)}");
        string withStatus = withANDStatus?.GetEnumDescription() ?? withORStatus?.GetEnumDescription().Replace(',', '|');

        if (withWatchMonetizationANDTypes != null && withWatchMonetizationORTypes != null)
            throw new ArgumentException($"Cannot set both {nameof(withWatchMonetizationANDTypes)} and {nameof(withWatchMonetizationORTypes)}");
        string monetizationTypes = withWatchMonetizationANDTypes?.GetEnumDescription() ?? withWatchMonetizationORTypes?.GetEnumDescription().Replace(',', '|');


        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "air_date.gte", airDateGte.DateOnlyToTmdb() },
            { "air_date.lte", airDateLte.DateOnlyToTmdb() },
            { "first_air_date.gte", firstAirDateGte.DateOnlyToTmdb() },
            { "first_air_date.lte", firstAirDateLte.DateOnlyToTmdb() },
            { "first_air_date_year", firstAirDateYear },
            { "include_adult", includeAdult },
            { "include_null_first_air_dates", includeNullFirstAirDates },
            { "language", language },
            { "screened_theatrically", screenedTheatrically },
            { "sort_by", sortBy.GetEnumDescription() },
            { "timezone", timezone },
            { "vote_average.gte", voteAverageGte },
            { "vote_average.lte", voteAverageLte },
            { "vote_count.gte", voteCountGte },
            { "vote_count.lte", voteCountLte },
            { "watch_region", watchRegion },
            { "with_companies", withCompanies },
            { "with_genres", withGenres },
            { "with_keywords", withKeywords },
            { "with_networks", withNetworks },
            { "with_original_language", withOriginalLanguage },
            { "with_origin_country", withOriginCountry },
            { "without_companies", withoutCompanies },
            { "without_genres", withoutGenres },
            { "without_keywords", withoutKeywords },
            { "without_watch_providers", withoutWatchProviders },
            { "with_runtime.gte", withRuntimeGte },
            { "with_runtime.lte", withRuntimeLte },
            { "with_status", withStatus },
            { "with_type", withType },
            { "with_watch_monetization_types", monetizationTypes },
            { "with_watch_providers", withWatchProviders }
        };

        return _client.GetAsync<PagedResult<CommonTvSeries2>>("/3/discover/tv", queryParams, cancellationToken);
    }
}
