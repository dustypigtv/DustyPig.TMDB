using DustyPig.REST;
using DustyPig.TMDB.Interfaces;
using DustyPig.TMDB.Models.TvSeries;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Clients;

internal class TvSeriesClient : ITvSeries
{
	private readonly Client _client;

	internal TvSeriesClient(Client client) => _client = client;


	/// <summary>
	/// Get the rating, watchlist and favourite status.
	/// </summary>
	public Task<Response<AccountStatesResponse>> GetAccountStatesAsync(int seriesId, string guestSessionId = null, string sessionId = null, CancellationToken cancellationToken = default)
	{
		var queryParams = new Dictionary<string, object>
		{
			{ "guest_session_id", guestSessionId },
			{ "session_id", sessionId }
		};

		return _client.GetAsync<AccountStatesResponse>($"/3/tv/{seriesId}/account_states", queryParams, cancellationToken);
	}

	/// <summary>
	/// Rate a TV show and save it to your rated list.
	/// </summary>
	public Task<Response<AddRatingResponse>> AddRatingAsync(AddRatingRequest postData, int seriesId, string guestSessionId = null, string sessionId = null, CancellationToken cancellationToken = default)
	{
		var queryParams = new Dictionary<string, object>
		{
			{ "guest_session_id", guestSessionId },
			{ "session_id", sessionId }
		};

		return _client.PostAsync<AddRatingResponse>($"/3/tv/{seriesId}/rating", queryParams, postData, cancellationToken);
	}

	/// <summary>
	/// Get the aggregate credits (cast and crew) that have been added to a TV show.
	/// </summary>
	public Task<Response<AggregateCreditsResponse>> GetAggregateCreditsAsync(int seriesId, string language = "en-US", CancellationToken cancellationToken = default)
	{
		var queryParams = new Dictionary<string, object>
		{
			{ "language", language }
		};

		return _client.GetAsync<AggregateCreditsResponse>($"/3/tv/{seriesId}/aggregate_credits", queryParams, cancellationToken);
	}

	/// <summary>
	/// Get a list of TV shows airing today.
	/// </summary>
	public Task<Response<AiringTodayResponse>> GetAiringTodayAsync(int page = 1, string language = "en-US", string timezone = null, CancellationToken cancellationToken = default)
	{
		var queryParams = new Dictionary<string, object>
		{
			{ "page", page },
			{ "language", language },
			{ "timezone", timezone }
		};

		return _client.GetAsync<AiringTodayResponse>("/3/tv/airing_today", queryParams, cancellationToken);
	}

	/// <summary>
	/// Get the alternative titles that have been added to a TV show.
	/// </summary>
	public Task<Response<AlternativeTitlesResponse>> GetAlternativeTitlesAsync(int seriesId, CancellationToken cancellationToken = default) =>
		_client.GetAsync<AlternativeTitlesResponse>($"/3/tv/{seriesId}/alternative_titles", null, cancellationToken);

	/// <summary>
	/// Get the recent changes for a TV show.
	/// </summary>
	public Task<Response<ChangesResponse>> GetChangesAsync(int seriesId, int page = 1, DateOnly? endDate = null, DateOnly? startDate = null, CancellationToken cancellationToken = default)
	{
		var queryParams = new Dictionary<string, object>
		{
			{ "page", page },
			{ "end_date", endDate.DateOnlyToTmdb() },
			{ "start_date", startDate.DateOnlyToTmdb() }
		};

		return _client.GetAsync<ChangesResponse>($"/3/tv/{seriesId}/changes", queryParams, cancellationToken);
	}

	/// <summary>
	/// Get the content ratings that have been added to a TV show.
	/// </summary>
	public Task<Response<ContentRatingsResponse>> GetContentRatingsAsync(int seriesId, CancellationToken cancellationToken = default) =>
		_client.GetAsync<ContentRatingsResponse>($"/3/tv/{seriesId}/content_ratings", null, cancellationToken);

	/// <summary>
	/// Get the latest season credits of a TV show.
	/// </summary>
	public Task<Response<CreditsResponse>> GetCreditsAsync(int seriesId, string language = "en-US", CancellationToken cancellationToken = default)
	{
		var queryParams = new Dictionary<string, object>
		{
			{ "language", language }
		};

		return _client.GetAsync<CreditsResponse>($"/3/tv/{seriesId}/credits", queryParams, cancellationToken);
	}

	/// <summary>
	/// Get the details of a TV show.
	/// </summary>
	/// <param name="appendToResponse">Info from endpoints in this namespace to add to the response. 20 values max.</param>
	public Task<Response<DetailsResponse>> GetDetailsAsync(int seriesId, AppendToResponse? appendToResponse = null, string language = "en-US", CancellationToken cancellationToken = default)
	{
		var queryParams = new Dictionary<string, object>
		{
			{ "append_to_response", appendToResponse?.GetEnumDescription() },
			{ "language", language }
		};

		return _client.GetAsync<DetailsResponse>($"/3/tv/{seriesId}", queryParams, cancellationToken);
	}

	/// <summary>
	/// Get the episode groups that have been added to a TV show.
	/// </summary>
	public Task<Response<EpisodeGroupsResponse>> GetEpisodeGroupsAsync(int seriesId, CancellationToken cancellationToken = default) =>
		_client.GetAsync<EpisodeGroupsResponse>($"/3/tv/{seriesId}/episode_groups", null, cancellationToken);

	/// <summary>
	/// Get a list of external IDs that have been added to a TV show.
	/// </summary>
	public Task<Response<ExternalIdsResponse>> GetExternalIdsAsync(int seriesId, CancellationToken cancellationToken = default) =>
		_client.GetAsync<ExternalIdsResponse>($"/3/tv/{seriesId}/external_ids", null, cancellationToken);

	/// <summary>
	/// Get the images that belong to a TV series.
	/// </summary>
	/// <param name="includeImageLanguage">specify a comma separated list of ISO-639-1 values to query, for example: `en,null`</param>
	public Task<Response<ImagesResponse>> GetImagesAsync(int seriesId, string includeImageLanguage = null, string language = "en-US", CancellationToken cancellationToken = default)
	{
		var queryParams = new Dictionary<string, object>
		{
			{ "include_image_language", includeImageLanguage },
			{ "language", language }
		};

		return _client.GetAsync<ImagesResponse>($"/3/tv/{seriesId}/images", queryParams, cancellationToken);
	}

	/// <summary>
	/// Get a list of keywords that have been added to a TV show.
	/// </summary>
	public Task<Response<KeywordsResponse>> GetKeywordsAsync(int seriesId, CancellationToken cancellationToken = default) =>
		_client.GetAsync<KeywordsResponse>($"/3/tv/{seriesId}/keywords", null, cancellationToken);

	/// <summary>
	/// Get the newest TV show ID.
	/// </summary>
	public Task<Response<LatestResponse>> GetLatestAsync(CancellationToken cancellationToken = default) =>
		_client.GetAsync<LatestResponse>("/3/tv/latest", null, cancellationToken);

	/// <summary>
	/// Get the lists that a TV series has been added to.
	/// </summary>
	public Task<Response<ListsResponse>> GetListsAsync(int seriesId, int page = 1, string language = "en-US", CancellationToken cancellationToken = default)
	{
		var queryParams = new Dictionary<string, object>
		{
			{ "page", page },
			{ "language", language }
		};

		return _client.GetAsync<ListsResponse>($"/3/tv/{seriesId}/lists", queryParams, cancellationToken);
	}

	/// <summary>
	/// Get a list of TV shows that air in the next 7 days.
	/// </summary>
	public Task<Response<OnTheAirResponse>> GetOnTheAirAsync(int page = 1, string language = "en-US", string timezone = null, CancellationToken cancellationToken = default)
	{
		var queryParams = new Dictionary<string, object>
		{
			{ "page", page },
			{ "language", language },
			{ "timezone", timezone }
		};

		return _client.GetAsync<OnTheAirResponse>("/3/tv/on_the_air", queryParams, cancellationToken);
	}

	/// <summary>
	/// Get a list of TV shows ordered by popularity.
	/// </summary>
	public Task<Response<PopularResponse>> GetPopularAsync(int page = 1, string language = "en-US", CancellationToken cancellationToken = default)
	{
		var queryParams = new Dictionary<string, object>
		{
			{ "page", page },
			{ "language", language }
		};

		return _client.GetAsync<PopularResponse>("/3/tv/popular", queryParams, cancellationToken);
	}

	public Task<Response<RecommendationsResponse>> GetRecommendationsAsync(int seriesId, int page = 1, string language = "en-US", CancellationToken cancellationToken = default)
	{
		var queryParams = new Dictionary<string, object>
		{
			{ "page", page },
			{ "language", language }
		};

		return _client.GetAsync<RecommendationsResponse>($"/3/tv/{seriesId}/recommendations", queryParams, cancellationToken);
	}

	/// <summary>
	/// Get the reviews that have been added to a TV show.
	/// </summary>
	public Task<Response<ReviewsResponse>> GetReviewsAsync(int seriesId, int page = 1, string language = "en-US", CancellationToken cancellationToken = default)
	{
		var queryParams = new Dictionary<string, object>
		{
			{ "page", page },
			{ "language", language }
		};

		return _client.GetAsync<ReviewsResponse>($"/3/tv/{seriesId}/reviews", queryParams, cancellationToken);
	}

	/// <summary>
	/// Get the seasons and episodes that have screened theatrically.
	/// </summary>
	public Task<Response<ScreenedTheatricallyResponse>> GetScreenedTheatricallyAsync(int seriesId, CancellationToken cancellationToken = default) =>
		_client.GetAsync<ScreenedTheatricallyResponse>($"/3/tv/{seriesId}/screened_theatrically", null, cancellationToken);

	/// <summary>
	/// Get the similar TV shows.
	/// </summary>
	public Task<Response<SimilarResponse>> GetSimilarAsync(string seriesId, int page = 1, string language = "en-US", CancellationToken cancellationToken = default)
	{
		var queryParams = new Dictionary<string, object>
		{
			{ "page", page },
			{ "language", language }
		};

		return _client.GetAsync<SimilarResponse>($"/3/tv/{seriesId}/similar", queryParams, cancellationToken);
	}

	/// <summary>
	/// Get a list of TV shows ordered by rating.
	/// </summary>
	public Task<Response<TopRatedResponse>> GetTopRatedAsync(int page = 1, string language = "en-US", CancellationToken cancellationToken = default)
	{
		var queryParams = new Dictionary<string, object>
		{
			{ "page", page },
			{ "language", language }
		};

		return _client.GetAsync<TopRatedResponse>("/3/tv/top_rated", queryParams, cancellationToken);
	}

	/// <summary>
	/// Get the translations that have been added to a TV show.
	/// </summary>
	public Task<Response<TranslationsResponse>> GetTranslationsAsync(int seriesId, CancellationToken cancellationToken = default) =>
		_client.GetAsync<TranslationsResponse>($"/3/tv/{seriesId}/translations", null, cancellationToken);

	/// <summary>
	/// Get the videos that belong to a TV show.
	/// </summary>
	/// <param name="includeVideoLanguage">filter the list results by language, supports more than one value by using a comma</param>
	public Task<Response<VideosResponse>> GetVideosAsync(int seriesId, string includeVideoLanguage = null, string language = "en-US", CancellationToken cancellationToken = default)
	{
		var queryParams = new Dictionary<string, object>
		{
			{ "include_video_language", includeVideoLanguage },
			{ "language", language }
		};

		return _client.GetAsync<VideosResponse>($"/3/tv/{seriesId}/videos", queryParams, cancellationToken);
	}

	/// <summary>
	/// Get the list of streaming providers we have for a TV show.
	/// </summary>
	public Task<Response<WatchProvidersResponse>> GetWatchProvidersAsync(int seriesId, CancellationToken cancellationToken = default) =>
		_client.GetAsync<WatchProvidersResponse>($"/3/tv/{seriesId}/watch/providers", null, cancellationToken);
}
