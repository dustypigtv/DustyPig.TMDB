using DustyPig.REST;
using DustyPig.TMDB.Models;
using DustyPig.TMDB.Models.Keyword;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Interfaces;

public interface IKeyword
{
    public Task<Response<DetailsResponse>> GetDetailsAsync(int keywordId, CancellationToken cancellationToken = default);

    public Task<Response<PagedResultWithId<MoviesResponse>>> GetMoviesAsync(string keywordId, int page = 1, bool? includeAdult = null, string language = "en-US", CancellationToken cancellationToken = default);
}
