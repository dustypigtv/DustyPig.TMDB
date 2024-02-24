using DustyPig.TMDB.Models.TvSeasons;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestsProject;

[TestClass]
public class TestTvSeasonsMethods
{
	[TestMethod]
	[DoNotParallelize]
	public async Task GetAccountStatesAsync()
	{
		//int seasonNumber = ;
		//int seriesId = ;
		string guestSessionId = null;
		string sessionId = null;

		//await ClientFactory.GetClient().Endpoints.TvSeasons.GetAccountStatesAsync(seasonNumber, seriesId, guestSessionId, sessionId);
	}



	[TestMethod]
	[DoNotParallelize]
	public async Task GetAggregateCreditsAsync()
	{
		//int seasonNumber = ;
		//int seriesId = ;
		string language = "en-US";

		//await ClientFactory.GetClient().Endpoints.TvSeasons.GetAggregateCreditsAsync(seasonNumber, seriesId, language);
	}



	[TestMethod]
	[DoNotParallelize]
	public async Task GetChangesAsync()
	{
		//int seasonId = ;
		int page = 1;
		DateOnly? endDate = null;
		DateOnly? startDate = null;

		//await ClientFactory.GetClient().Endpoints.TvSeasons.GetChangesAsync(seasonId, page, endDate, startDate);
	}



	[TestMethod]
	[DoNotParallelize]
	public async Task GetCreditsAsync()
	{
		//int seasonNumber = ;
		//int seriesId = ;
		string language = "en-US";

		//await ClientFactory.GetClient().Endpoints.TvSeasons.GetCreditsAsync(seasonNumber, seriesId, language);
	}



	[TestMethod]
	[DoNotParallelize]
	public async Task GetDetailsAsync()
	{
		//int seasonNumber = ;
		//int seriesId = ;
		AppendToResponse? appendToResponse = null;
		string language = "en-US";

		//await ClientFactory.GetClient().Endpoints.TvSeasons.GetDetailsAsync(seasonNumber, seriesId, appendToResponse, language);
	}



	[TestMethod]
	[DoNotParallelize]
	public async Task GetExternalIdsAsync()
	{
		//int seasonNumber = ;
		//int seriesId = ;

		//await ClientFactory.GetClient().Endpoints.TvSeasons.GetExternalIdsAsync(seasonNumber, seriesId);
	}



	[TestMethod]
	[DoNotParallelize]
	public async Task GetImagesAsync()
	{
		//int seasonNumber = ;
		//int seriesId = ;
		string includeImageLanguage = null;
		string language = "en-US";

		//await ClientFactory.GetClient().Endpoints.TvSeasons.GetImagesAsync(seasonNumber, seriesId, includeImageLanguage, language);
	}



	[TestMethod]
	[DoNotParallelize]
	public async Task GetTranslationsAsync()
	{
		//int seasonNumber = ;
		//int seriesId = ;

		//await ClientFactory.GetClient().Endpoints.TvSeasons.GetTranslationsAsync(seasonNumber, seriesId);
	}



	[TestMethod]
	[DoNotParallelize]
	public async Task GetVideosAsync()
	{
		//int seasonNumber = ;
		//int seriesId = ;
		string includeVideoLanguage = null;
		string language = "en-US";

		//await ClientFactory.GetClient().Endpoints.TvSeasons.GetVideosAsync(seasonNumber, seriesId, includeVideoLanguage, language);
	}



	[TestMethod]
	[DoNotParallelize]
	public async Task GetWatchProvidersAsync()
	{
		//int seasonNumber = ;
		//int seriesId = ;
		string language = "en-US";

		//await ClientFactory.GetClient().Endpoints.TvSeasons.GetWatchProvidersAsync(seasonNumber, seriesId, language);
	}
}
