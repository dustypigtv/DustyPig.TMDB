using DustyPig.TMDB.Models.Common;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Interfaces;

public interface IKeywords
{
    public Task<Response<CommonName>> GetDetailsAsync(int keywordId, CancellationToken cancellationToken = default);
}
