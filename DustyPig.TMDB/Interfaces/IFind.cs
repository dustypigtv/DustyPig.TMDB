using DustyPig.REST;
using DustyPig.TMDB.Models.Find;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Interfaces;

public interface IFind
{
    /// <summary>
    /// Find data by external ID&#39;s.
    /// </summary>
    public Task<Response<FindResult>> ByIdAsync(string externalId, Externalsource externalSource, string language = "en-US", CancellationToken cancellationToken = default);
}
