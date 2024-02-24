using DustyPig.TMDB.Models.Collections;
using DustyPig.TMDB.Models.Common;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Interfaces;

public interface ICollections
{
    /// <summary>
    /// Get collection details by ID.
    /// </summary>
    public Task<Response<Details>> GetDetailsAsync(int collectionId, string language = "en-US", CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the images that belong to a collection.
    /// If you have a language specified, it will act as a filter on the returned items. You can use the include_image_language param to query additional languages.
    /// </summary>
    /// <param name="includeImageLanguage">specify a comma separated list of ISO-639-1 values to query, for example: `en,null`</param>
    public Task<Response<Images>> GetImagesAsync(int collectionId, string includeImageLanguage = null, string language = "en-US", CancellationToken cancellationToken = default);

    public Task<Response<CommonTranslationList<Translation>>> GetTranslationsAsync(int collectionId, CancellationToken cancellationToken = default);
}
