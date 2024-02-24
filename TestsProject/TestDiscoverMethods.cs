using DustyPig.TMDB.Models.Common;
using DustyPig.TMDB.Models.Discover;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestsProject;

[TestClass]
public class TestDiscoverMethods
{
	[TestMethod]
	[DoNotParallelize]
	public async Task GetMovieAsync()
	{
		int page = 1;
		string certification = null;
		string certificationCountry = null;
		string certificationGte = null;
		string certificationLte = null;
		bool? includeAdult = null;
		bool? includeVideo = null;
		string language = "en-US";
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
		string withOriginalLanguage = null;
		string withOriginCountry = null;
		string withoutCompanies = null;
		string withoutGenres = null;
		string withoutKeywords = null;
		string withoutWatchProviders = null;
		string withPeople = null;
		MovieReleaseTypes? withReleaseANDType = null;
		MovieReleaseTypes? withReleaseORType = null;
		int? withRuntimeGte = null;
		int? withRuntimeLte = null;
		WatchMonetizationTypes? withWatchMonetizationANDTypes = null;
		WatchMonetizationTypes? withWatchMonetizationORTypes = null;
		string withWatchProviders = null;
		int? year = null;

		//await ClientFactory.GetClient().Endpoints.Discover.GetMovieAsync(page, certification, certificationCountry, certificationGte, certificationLte, includeAdult, includeVideo, language, primaryReleaseDateGte, primaryReleaseDateLte, primaryReleaseYear, region, releaseDateGte, releaseDateLte, sortBy, voteAverageGte, voteAverageLte, voteCountGte, voteCountLte, watchRegion, withCast, withCompanies, withCrew, withGenres, withKeywords, withOriginalLanguage, withOriginCountry, withoutCompanies, withoutGenres, withoutKeywords, withoutWatchProviders, withPeople, withReleaseANDType, withReleaseORType, withRuntimeGte, withRuntimeLte, withWatchMonetizationANDTypes, withWatchMonetizationORTypes, withWatchProviders, year);
	}



	[TestMethod]
	[DoNotParallelize]
	public async Task GetTvAsync()
	{
		int page = 1;
		DateOnly? airDateGte = null;
		DateOnly? airDateLte = null;
		DateOnly? firstAirDateGte = null;
		DateOnly? firstAirDateLte = null;
		int? firstAirDateYear = null;
		bool? includeAdult = null;
		bool? includeNullFirstAirDates = null;
		string language = "en-US";
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
		TvSeriesStatus? withANDStatus = null;
		TvSeriesStatus? withORStatus = null;
		CommonTvSeriesTypes? withANDType = null;
		CommonTvSeriesTypes? withORType = null;
		WatchMonetizationTypes? withWatchMonetizationANDTypes = null;
		WatchMonetizationTypes? withWatchMonetizationORTypes = null;
		string withWatchProviders = null;

		//await ClientFactory.GetClient().Endpoints.Discover.GetTvAsync(page, airDateGte, airDateLte, firstAirDateGte, firstAirDateLte, firstAirDateYear, includeAdult, includeNullFirstAirDates, language, screenedTheatrically, sortBy, timezone, voteAverageGte, voteAverageLte, voteCountGte, voteCountLte, watchRegion, withCompanies, withGenres, withKeywords, withNetworks, withOriginalLanguage, withOriginCountry, withoutCompanies, withoutGenres, withoutKeywords, withoutWatchProviders, withRuntimeGte, withRuntimeLte, withANDStatus, withORStatus, withANDType, withORType, withWatchMonetizationANDTypes, withWatchMonetizationORTypes, withWatchProviders);
	}
}
