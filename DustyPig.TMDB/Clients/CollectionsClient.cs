using DustyPig.TMDB.Interfaces;
using DustyPig.TMDB.Models.Collections;
using DustyPig.TMDB.Models.Common;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Clients;

internal class CollectionsClient : ICollections
{
    private readonly Client _client;

    internal CollectionsClient(Client client) => _client = client;


    /// <summary>
    /// Get collection details by ID.
    /// </summary>
    public Task<Response<Details>> GetDetailsAsync(int collectionId, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "language", language }
        };

        return _client.GetAsync<Details>($"/3/collection/{collectionId}", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get the images that belong to a collection.
    /// </summary>
    /// <param name="includeImageLanguage">specify a comma separated list of ISO-639-1 values to query, for example: `en,null`</param>
    public Task<Response<Images>> GetImagesAsync(int collectionId, string includeImageLanguage = null, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "include_image_language", includeImageLanguage },
            { "language", language }
        };

        return _client.GetAsync<Images>($"/3/collection/{collectionId}/images", queryParams, cancellationToken);
    }

    public Task<Response<CommonTranslationList<Translation>>> GetTranslationsAsync(int collectionId, CancellationToken cancellationToken = default) =>
        _client.GetAsync<CommonTranslationList<Translation>>($"/3/collection/{collectionId}/translations", null, cancellationToken);
}
