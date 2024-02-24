using DustyPig.TMDB.Models.Common;
using DustyPig.TMDB.Models.TvSeries;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestsProject;

[TestClass]
public class TestTvSeriesMethods
{
	[TestMethod]
	[DoNotParallelize]
	public async Task GetAccountStatesAsync()
	{
		//int seriesId = ;
		string guestSessionId = null;
		string sessionId = null;

		//await ClientFactory.GetClient().Endpoints.TvSeries.GetAccountStatesAsync(seriesId, guestSessionId, sessionId);
	}



	[TestMethod]
	[DoNotParallelize]
	public async Task AddRatingAsync()
	{
		//CommonValue1 postData = ;
		//int seriesId = ;
		string guestSessionId = null;
		string sessionId = null;

		//await ClientFactory.GetClient().Endpoints.TvSeries.AddRatingAsync(postData, seriesId, guestSessionId, sessionId);
	}



	[TestMethod]
	[DoNotParallelize]
	public async Task GetAggregateCreditsAsync()
	{
		//int seriesId = ;
		string language = "en-US";

		//await ClientFactory.GetClient().Endpoints.TvSeries.GetAggregateCreditsAsync(seriesId, language);
	}



	[TestMethod]
	[DoNotParallelize]
	public async Task GetAlternativeTitlesAsync()
	{
		//int seriesId = ;

		//await ClientFactory.GetClient().Endpoints.TvSeries.GetAlternativeTitlesAsync(seriesId);
	}



	[TestMethod]
	[DoNotParallelize]
	public async Task GetChangesAsync()
	{
		//int seriesId = ;
		int page = 1;
		DateOnly? endDate = null;
		DateOnly? startDate = null;

		//await ClientFactory.GetClient().Endpoints.TvSeries.GetChangesAsync(seriesId, page, endDate, startDate);
	}



	[TestMethod]
	[DoNotParallelize]
	public async Task GetContentRatingsAsync()
	{
		//int seriesId = ;

		//await ClientFactory.GetClient().Endpoints.TvSeries.GetContentRatingsAsync(seriesId);
	}



	[TestMethod]
	[DoNotParallelize]
	public async Task GetCreditsAsync()
	{
		//int seriesId = ;
		string language = "en-US";

		//await ClientFactory.GetClient().Endpoints.TvSeries.GetCreditsAsync(seriesId, language);
	}



	[TestMethod]
	[DoNotParallelize]
	public async Task GetDetailsAsync()
	{
		//int seriesId = ;
		AppendToResponse? appendToResponse = null;
		string language = "en-US";

		//await ClientFactory.GetClient().Endpoints.TvSeries.GetDetailsAsync(seriesId, appendToResponse, language);
	}



	[TestMethod]
	[DoNotParallelize]
	public async Task GetEpisodeGroupsAsync()
	{
		//int seriesId = ;

		//await ClientFactory.GetClient().Endpoints.TvSeries.GetEpisodeGroupsAsync(seriesId);
	}



	[TestMethod]
	[DoNotParallelize]
	public async Task GetExternalIdsAsync()
	{
		//int seriesId = ;

		//await ClientFactory.GetClient().Endpoints.TvSeries.GetExternalIdsAsync(seriesId);
	}



	[TestMethod]
	[DoNotParallelize]
	public async Task GetImagesAsync()
	{
		//int seriesId = ;
		string includeImageLanguage = null;
		string language = "en-US";

		//await ClientFactory.GetClient().Endpoints.TvSeries.GetImagesAsync(seriesId, includeImageLanguage, language);
	}



	[TestMethod]
	[DoNotParallelize]
	public async Task GetKeywordsAsync()
	{
		//int seriesId = ;

		//await ClientFactory.GetClient().Endpoints.TvSeries.GetKeywordsAsync(seriesId);
	}



	[TestMethod]
	[DoNotParallelize]
	public async Task GetLatestAsync()
	{
		await ClientFactory.GetClient().Endpoints.TvSeries.GetLatestAsync();
	}



	[TestMethod]
	[DoNotParallelize]
	public async Task GetListsAsync()
	{
		//int seriesId = ;
		int page = 1;
		string language = "en-US";

		//await ClientFactory.GetClient().Endpoints.TvSeries.GetListsAsync(seriesId, page, language);
	}



	[TestMethod]
	[DoNotParallelize]
	public async Task GetRecommendationsAsync()
	{
		//int seriesId = ;
		int page = 1;
		string language = "en-US";

		//await ClientFactory.GetClient().Endpoints.TvSeries.GetRecommendationsAsync(seriesId, page, language);
	}



	[TestMethod]
	[DoNotParallelize]
	public async Task GetReviewsAsync()
	{
		//int seriesId = ;
		int page = 1;
		string language = "en-US";

		//await ClientFactory.GetClient().Endpoints.TvSeries.GetReviewsAsync(seriesId, page, language);
	}



	[TestMethod]
	[DoNotParallelize]
	public async Task GetScreenedTheatricallyAsync()
	{
		//int seriesId = ;

		//await ClientFactory.GetClient().Endpoints.TvSeries.GetScreenedTheatricallyAsync(seriesId);
	}



	[TestMethod]
	[DoNotParallelize]
	public async Task GetSimilarAsync()
	{
		//string seriesId = ;
		int page = 1;
		string language = "en-US";

		//await ClientFactory.GetClient().Endpoints.TvSeries.GetSimilarAsync(seriesId, page, language);
	}



	[TestMethod]
	[DoNotParallelize]
	public async Task GetTranslationsAsync()
	{
		//int seriesId = ;

		//await ClientFactory.GetClient().Endpoints.TvSeries.GetTranslationsAsync(seriesId);
	}



	[TestMethod]
	[DoNotParallelize]
	public async Task GetVideosAsync()
	{
		//int seriesId = ;
		string includeVideoLanguage = null;
		string language = "en-US";

		//await ClientFactory.GetClient().Endpoints.TvSeries.GetVideosAsync(seriesId, includeVideoLanguage, language);
	}



	[TestMethod]
	[DoNotParallelize]
	public async Task GetWatchProvidersAsync()
	{
		//int seriesId = ;

		//await ClientFactory.GetClient().Endpoints.TvSeries.GetWatchProvidersAsync(seriesId);
	}
}
