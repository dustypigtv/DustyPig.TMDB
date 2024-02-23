using DustyPig.REST;
using DustyPig.TMDB.Models.Keyword;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Interfaces;

public interface IKeyword
{
    public Task<Response<DetailsResponse>> GetDetailsAsync(int keywordId, CancellationToken cancellationToken = default);
}
