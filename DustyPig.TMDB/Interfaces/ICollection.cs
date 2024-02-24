using DustyPig.REST;
using DustyPig.TMDB.Models.Collection;
using DustyPig.TMDB.Models.Common;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Interfaces;

public interface ICollection
{
    /// <summary>
    /// Get collection details by ID.
    /// </summary>
    public Task<Response<DetailsResponse>> GetDetailsAsync(int collectionId, string language = "en-US", CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the images that belong to a collection.
    /// </summary>
    /// <param name="includeImageLanguage">specify a comma separated list of ISO-639-1 values to query, for example: `en,null`</param>
    public Task<Response<ImagesResponse>> GetImagesAsync(int collectionId, string includeImageLanguage = null, string language = "en-US", CancellationToken cancellationToken = default);

    public Task<Response<CommonTranslationList<TranslationData>>> GetTranslationsAsync(int collectionId, CancellationToken cancellationToken = default);
}
