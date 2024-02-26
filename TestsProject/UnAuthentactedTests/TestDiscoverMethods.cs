using DustyPig.TMDB.Models.Common;
using DustyPig.TMDB.Models.Discover;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsProject.UnAuthentactedTests;

[TestClass]
public class TestDiscoverMethods
{
    [TestMethod]
    [DoNotParallelize]
    public async Task GetMovie()
    {
        int page = 1;
        string certification = null;
        string certificationCountry = null;
        string certificationGte = null;
        string certificationLte = null;
        bool? includeAdult = null;
        bool? includeVideo = null;
        string language = Constants.Language;
        string withOriginalLanguage = null;
        DateOnly? primaryReleaseDateGte = null;
        DateOnly? primaryReleaseDateLte = null;
        int? primaryReleaseYear = null;
        string region = null;
        DateOnly? releaseDateGte = null;
        DateOnly? releaseDateLte = null;
        SortMoviesBy sortBy = SortMoviesBy.PopularityDesc;
        float? voteAverageGte = null;
        float? voteAverageLte = null;
        float? voteCountGte = null;
        float? voteCountLte = null;
        string watchRegion = null;
        string withCast = null;
        string withCompanies = null;
        string withCrew = null;
        string withGenres = null;
        string withKeywords = null;
        string withOriginCountry = null;
        string withoutCompanies = null;
        string withoutGenres = null;
        string withoutKeywords = null;
        string withoutWatchProviders = null;
        string withPeople = null;
        int? withRuntimeGte = null;
        int? withRuntimeLte = null;
        string withWatchProviders = null;
        int? year = null;

        MovieReleaseTypes?[] movieReleaseTypes = [null, MovieReleaseTypes.Digital, MovieReleaseTypes.Physical | MovieReleaseTypes.Premier];
        WatchMonetizationTypes?[] watchMonetizationTypes = [null, WatchMonetizationTypes.FlatRate, WatchMonetizationTypes.FlatRate | WatchMonetizationTypes.Buy];

        foreach (var withReleaseANDType in movieReleaseTypes)
        {
            MovieReleaseTypes? withReleaseORType = null;
            WatchMonetizationTypes? withWatchMonetizationANDTypes = null;
            WatchMonetizationTypes? withWatchMonetizationORTypes = null;
            await ClientFactory.GetClient().Endpoints.Discover.GetMovieAsync(page, certification, certificationCountry, certificationGte, certificationLte, includeAdult, includeVideo, language, primaryReleaseDateGte, primaryReleaseDateLte, primaryReleaseYear, region, releaseDateGte, releaseDateLte, sortBy, voteAverageGte, voteAverageLte, voteCountGte, voteCountLte, watchRegion, withCast, withCompanies, withCrew, withGenres, withKeywords, withOriginalLanguage, withOriginCountry, withoutCompanies, withoutGenres, withoutKeywords, withoutWatchProviders, withPeople, withReleaseANDType, withReleaseORType, withRuntimeGte, withRuntimeLte, withWatchMonetizationANDTypes, withWatchMonetizationORTypes, withWatchProviders, year);
        }

        foreach (var withReleaseORType in movieReleaseTypes)
        {
            MovieReleaseTypes? withReleaseANDType = null;
            WatchMonetizationTypes? withWatchMonetizationANDTypes = null;
            WatchMonetizationTypes? withWatchMonetizationORTypes = null;
            await ClientFactory.GetClient().Endpoints.Discover.GetMovieAsync(page, certification, certificationCountry, certificationGte, certificationLte, includeAdult, includeVideo, language, primaryReleaseDateGte, primaryReleaseDateLte, primaryReleaseYear, region, releaseDateGte, releaseDateLte, sortBy, voteAverageGte, voteAverageLte, voteCountGte, voteCountLte, watchRegion, withCast, withCompanies, withCrew, withGenres, withKeywords, withOriginalLanguage, withOriginCountry, withoutCompanies, withoutGenres, withoutKeywords, withoutWatchProviders, withPeople, withReleaseANDType, withReleaseORType, withRuntimeGte, withRuntimeLte, withWatchMonetizationANDTypes, withWatchMonetizationORTypes, withWatchProviders, year);
        }

        foreach (var withWatchMonetizationANDTypes in watchMonetizationTypes)
        {
            MovieReleaseTypes? withReleaseANDType = null;
            MovieReleaseTypes? withReleaseORType = null;
            WatchMonetizationTypes? withWatchMonetizationORTypes = null;
            await ClientFactory.GetClient().Endpoints.Discover.GetMovieAsync(page, certification, certificationCountry, certificationGte, certificationLte, includeAdult, includeVideo, language, primaryReleaseDateGte, primaryReleaseDateLte, primaryReleaseYear, region, releaseDateGte, releaseDateLte, sortBy, voteAverageGte, voteAverageLte, voteCountGte, voteCountLte, watchRegion, withCast, withCompanies, withCrew, withGenres, withKeywords, withOriginalLanguage, withOriginCountry, withoutCompanies, withoutGenres, withoutKeywords, withoutWatchProviders, withPeople, withReleaseANDType, withReleaseORType, withRuntimeGte, withRuntimeLte, withWatchMonetizationANDTypes, withWatchMonetizationORTypes, withWatchProviders, year);
        }

        foreach (var withWatchMonetizationORTypes in watchMonetizationTypes)
        {
            MovieReleaseTypes? withReleaseANDType = null;
            MovieReleaseTypes? withReleaseORType = null;
            WatchMonetizationTypes? withWatchMonetizationANDTypes = null;
            await ClientFactory.GetClient().Endpoints.Discover.GetMovieAsync(page, certification, certificationCountry, certificationGte, certificationLte, includeAdult, includeVideo, language, primaryReleaseDateGte, primaryReleaseDateLte, primaryReleaseYear, region, releaseDateGte, releaseDateLte, sortBy, voteAverageGte, voteAverageLte, voteCountGte, voteCountLte, watchRegion, withCast, withCompanies, withCrew, withGenres, withKeywords, withOriginalLanguage, withOriginCountry, withoutCompanies, withoutGenres, withoutKeywords, withoutWatchProviders, withPeople, withReleaseANDType, withReleaseORType, withRuntimeGte, withRuntimeLte, withWatchMonetizationANDTypes, withWatchMonetizationORTypes, withWatchProviders, year);
        }
    }



    [TestMethod]
    [DoNotParallelize]
    public async Task GetTvSeries()
    {
        int page = 1;
        DateOnly? airDateGte = null;
        DateOnly? airDateLte = null;
        DateOnly? firstAirDateGte = null;
        DateOnly? firstAirDateLte = null;
        int? firstAirDateYear = null;
        bool? includeAdult = null;
        bool? includeNullFirstAirDates = null;
        string language = Constants.Language;
        bool? screenedTheatrically = null;
        SortTvSeriesBy sortBy = SortTvSeriesBy.PopularityDesc;
        string timezone = null;
        float? voteAverageGte = null;
        float? voteAverageLte = null;
        float? voteCountGte = null;
        float? voteCountLte = null;
        string watchRegion = null;
        string withCompanies = null;
        string withGenres = null;
        string withKeywords = null;
        int? withNetworks = null;
        string withOriginalLanguage = null;
        string withOriginCountry = null;
        string withoutCompanies = null;
        string withoutGenres = null;
        string withoutKeywords = null;
        string withoutWatchProviders = null;
        int? withRuntimeGte = null;
        int? withRuntimeLte = null;
        string withWatchProviders = null;

        TvSeriesStatus?[] tvSeriesStatuses = [null, TvSeriesStatus.Returning, TvSeriesStatus.InProduction | TvSeriesStatus.Ended];
        CommonTvSeriesTypes?[] tvSeriesTypes = [null, CommonTvSeriesTypes.Video, CommonTvSeriesTypes.News | CommonTvSeriesTypes.Scripted];
        WatchMonetizationTypes?[] watchMonetizationTypes = [null, WatchMonetizationTypes.FlatRate, WatchMonetizationTypes.FlatRate | WatchMonetizationTypes.Buy];

        foreach (var withANDStatus in tvSeriesStatuses)
        {
            TvSeriesStatus? withORStatus = null;
            CommonTvSeriesTypes? withANDType = null;
            CommonTvSeriesTypes? withORType = null;
            WatchMonetizationTypes? withWatchMonetizationANDTypes = null;
            WatchMonetizationTypes? withWatchMonetizationORTypes = null;

            await ClientFactory.GetClient().Endpoints.Discover.GetTvSeriesAsync(page, airDateGte, airDateLte, firstAirDateGte, firstAirDateLte, firstAirDateYear, includeAdult, includeNullFirstAirDates, language, screenedTheatrically, sortBy, timezone, voteAverageGte, voteAverageLte, voteCountGte, voteCountLte, watchRegion, withCompanies, withGenres, withKeywords, withNetworks, withOriginalLanguage, withOriginCountry, withoutCompanies, withoutGenres, withoutKeywords, withoutWatchProviders, withRuntimeGte, withRuntimeLte, withANDStatus, withORStatus, withANDType, withORType, withWatchMonetizationANDTypes, withWatchMonetizationORTypes, withWatchProviders);
        }

        foreach (var withORStatus in tvSeriesStatuses)
        {
            TvSeriesStatus? withANDStatus = null;
            CommonTvSeriesTypes? withANDType = null;
            CommonTvSeriesTypes? withORType = null;
            WatchMonetizationTypes? withWatchMonetizationANDTypes = null;
            WatchMonetizationTypes? withWatchMonetizationORTypes = null;

            await ClientFactory.GetClient().Endpoints.Discover.GetTvSeriesAsync(page, airDateGte, airDateLte, firstAirDateGte, firstAirDateLte, firstAirDateYear, includeAdult, includeNullFirstAirDates, language, screenedTheatrically, sortBy, timezone, voteAverageGte, voteAverageLte, voteCountGte, voteCountLte, watchRegion, withCompanies, withGenres, withKeywords, withNetworks, withOriginalLanguage, withOriginCountry, withoutCompanies, withoutGenres, withoutKeywords, withoutWatchProviders, withRuntimeGte, withRuntimeLte, withANDStatus, withORStatus, withANDType, withORType, withWatchMonetizationANDTypes, withWatchMonetizationORTypes, withWatchProviders);
        }

        foreach (var withANDType in tvSeriesTypes)
        {
            TvSeriesStatus? withANDStatus = null;
            TvSeriesStatus? withORStatus = null;
            CommonTvSeriesTypes? withORType = null;
            WatchMonetizationTypes? withWatchMonetizationANDTypes = null;
            WatchMonetizationTypes? withWatchMonetizationORTypes = null;

            await ClientFactory.GetClient().Endpoints.Discover.GetTvSeriesAsync(page, airDateGte, airDateLte, firstAirDateGte, firstAirDateLte, firstAirDateYear, includeAdult, includeNullFirstAirDates, language, screenedTheatrically, sortBy, timezone, voteAverageGte, voteAverageLte, voteCountGte, voteCountLte, watchRegion, withCompanies, withGenres, withKeywords, withNetworks, withOriginalLanguage, withOriginCountry, withoutCompanies, withoutGenres, withoutKeywords, withoutWatchProviders, withRuntimeGte, withRuntimeLte, withANDStatus, withORStatus, withANDType, withORType, withWatchMonetizationANDTypes, withWatchMonetizationORTypes, withWatchProviders);
        }

        foreach (var withORType in tvSeriesTypes)
        {
            TvSeriesStatus? withANDStatus = null;
            TvSeriesStatus? withORStatus = null;
            CommonTvSeriesTypes? withANDType = null;
            WatchMonetizationTypes? withWatchMonetizationANDTypes = null;
            WatchMonetizationTypes? withWatchMonetizationORTypes = null;

            await ClientFactory.GetClient().Endpoints.Discover.GetTvSeriesAsync(page, airDateGte, airDateLte, firstAirDateGte, firstAirDateLte, firstAirDateYear, includeAdult, includeNullFirstAirDates, language, screenedTheatrically, sortBy, timezone, voteAverageGte, voteAverageLte, voteCountGte, voteCountLte, watchRegion, withCompanies, withGenres, withKeywords, withNetworks, withOriginalLanguage, withOriginCountry, withoutCompanies, withoutGenres, withoutKeywords, withoutWatchProviders, withRuntimeGte, withRuntimeLte, withANDStatus, withORStatus, withANDType, withORType, withWatchMonetizationANDTypes, withWatchMonetizationORTypes, withWatchProviders);
        }

        foreach (var withWatchMonetizationANDTypes in watchMonetizationTypes)
        {
            TvSeriesStatus? withANDStatus = null;
            TvSeriesStatus? withORStatus = null;
            CommonTvSeriesTypes? withANDType = null;
            CommonTvSeriesTypes? withORType = null;
            WatchMonetizationTypes? withWatchMonetizationORTypes = null;

            await ClientFactory.GetClient().Endpoints.Discover.GetTvSeriesAsync(page, airDateGte, airDateLte, firstAirDateGte, firstAirDateLte, firstAirDateYear, includeAdult, includeNullFirstAirDates, language, screenedTheatrically, sortBy, timezone, voteAverageGte, voteAverageLte, voteCountGte, voteCountLte, watchRegion, withCompanies, withGenres, withKeywords, withNetworks, withOriginalLanguage, withOriginCountry, withoutCompanies, withoutGenres, withoutKeywords, withoutWatchProviders, withRuntimeGte, withRuntimeLte, withANDStatus, withORStatus, withANDType, withORType, withWatchMonetizationANDTypes, withWatchMonetizationORTypes, withWatchProviders);
        }

        foreach (var withWatchMonetizationANDTypes in watchMonetizationTypes)
        {
            TvSeriesStatus? withANDStatus = null;
            TvSeriesStatus? withORStatus = null;
            CommonTvSeriesTypes? withANDType = null;
            CommonTvSeriesTypes? withORType = null;
            WatchMonetizationTypes? withWatchMonetizationORTypes = null;

            await ClientFactory.GetClient().Endpoints.Discover.GetTvSeriesAsync(page, airDateGte, airDateLte, firstAirDateGte, firstAirDateLte, firstAirDateYear, includeAdult, includeNullFirstAirDates, language, screenedTheatrically, sortBy, timezone, voteAverageGte, voteAverageLte, voteCountGte, voteCountLte, watchRegion, withCompanies, withGenres, withKeywords, withNetworks, withOriginalLanguage, withOriginCountry, withoutCompanies, withoutGenres, withoutKeywords, withoutWatchProviders, withRuntimeGte, withRuntimeLte, withANDStatus, withORStatus, withANDType, withORType, withWatchMonetizationANDTypes, withWatchMonetizationORTypes, withWatchProviders);
        }
    }
}