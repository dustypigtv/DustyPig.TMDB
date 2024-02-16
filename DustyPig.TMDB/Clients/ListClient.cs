using DustyPig.REST;
using DustyPig.TMDB.Interfaces;
using DustyPig.TMDB.Models.List;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Clients;

internal class ListClient : IList
{
	private readonly Client _client;

	internal ListClient(Client client) => _client = client;


	/// <summary>
	/// Add a movie to a list.
	/// </summary>
	public Task<Response<AddMovieResponse>> AddMovieAsync(AddMovieRequest postData, int listId, string sessionId, CancellationToken cancellationToken = default)
	{
		var queryParams = new Dictionary<string, object>
		{
			{ "session_id", sessionId }
		};

		return _client.PostAsync<AddMovieResponse>($"/3/list/{listId}/add_item", queryParams, postData, cancellationToken);
	}

	/// <summary>
	/// Use this method to check if an item has already been added to the list.
	/// </summary>
	public Task<Response<CheckItemStatusResponse>> GetCheckItemStatusAsync(int listId, string language = "en-US", int? movieId = null, CancellationToken cancellationToken = default)
	{
		var queryParams = new Dictionary<string, object>
		{
			{ "language", language },
			{ "movie_id", movieId }
		};

		return _client.GetAsync<CheckItemStatusResponse>($"/3/list/{listId}/item_status", queryParams, cancellationToken);
	}

	/// <summary>
	/// Clear all items from a list.
	/// </summary>
	public Task<Response<ClearResponse>> ClearAsync(int listId, bool confirm, string sessionId, CancellationToken cancellationToken = default)
	{
		var queryParams = new Dictionary<string, object>
		{
			{ "confirm", confirm },
			{ "session_id", sessionId }
		};

		return _client.PostAsync<ClearResponse>($"/3/list/{listId}/clear", queryParams, null, cancellationToken);
	}

	public Task<Response<CreateResponse>> CreateAsync(CreateRequest postData, string sessionId, CancellationToken cancellationToken = default)
	{
		var queryParams = new Dictionary<string, object>
		{
			{ "session_id", sessionId }
		};

		return _client.PostAsync<CreateResponse>("/3/list", queryParams, postData, cancellationToken);
	}

	public Task<Response<DetailsResponse>> GetDetailsAsync(int listId, int page = 1, string language = "en-US", CancellationToken cancellationToken = default)
	{
		var queryParams = new Dictionary<string, object>
		{
			{ "page", page },
			{ "language", language }
		};

		return _client.GetAsync<DetailsResponse>($"/3/list/{listId}", queryParams, cancellationToken);
	}

	/// <summary>
	/// Remove a movie from a list.
	/// </summary>
	public Task<Response<RemoveMovieResponse>> RemoveMovieAsync(RemoveMovieRequest postData, int listId, string sessionId, CancellationToken cancellationToken = default)
	{
		var queryParams = new Dictionary<string, object>
		{
			{ "session_id", sessionId }
		};

		return _client.PostAsync<RemoveMovieResponse>($"/3/list/{listId}/remove_item", queryParams, postData, cancellationToken);
	}
}
