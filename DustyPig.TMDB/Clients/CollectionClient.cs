using DustyPig.REST;
using DustyPig.TMDB.Interfaces;
using DustyPig.TMDB.Models.Collection;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Clients;

internal class CollectionClient : ICollection
{
	private readonly Client _client;

	internal CollectionClient(Client client) => _client = client;


	/// <summary>
	/// Get collection details by ID.
	/// </summary>
	public Task<Response<DetailsResponse>> GetDetailsAsync(int collectionId, string language = "en-US", CancellationToken cancellationToken = default)
	{
		var queryParams = new Dictionary<string, object>
		{
			{ "language", language }
		};

		return _client.GetAsync<DetailsResponse>($"/3/collection/{collectionId}", queryParams, cancellationToken);
	}

	/// <summary>
	/// Get the images that belong to a collection.
	/// </summary>
	/// <param name="includeImageLanguage">specify a comma separated list of ISO-639-1 values to query, for example: `en,null`</param>
	public Task<Response<ImagesResponse>> GetImagesAsync(int collectionId, string includeImageLanguage = null, string language = "en-US", CancellationToken cancellationToken = default)
	{
		var queryParams = new Dictionary<string, object>
		{
			{ "include_image_language", includeImageLanguage },
			{ "language", language }
		};

		return _client.GetAsync<ImagesResponse>($"/3/collection/{collectionId}/images", queryParams, cancellationToken);
	}

	public Task<Response<TranslationsResponse>> GetTranslationsAsync(int collectionId, CancellationToken cancellationToken = default) =>
		_client.GetAsync<TranslationsResponse>($"/3/collection/{collectionId}/translations", null, cancellationToken);
}
