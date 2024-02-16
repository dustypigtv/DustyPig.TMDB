using DustyPig.TMDB.Clients;
using DustyPig.TMDB.Interfaces;

namespace DustyPig.TMDB.Models;

internal class Endpoints : IEndpoints
{
    private readonly Client _client;

    internal Endpoints(Client client) => _client = client;

	public IAccount Account => new AccountClient(_client);

	public IAuthentication Authentication => new AuthenticationClient(_client);

	public ICertification Certification => new CertificationClient(_client);

	public IChanges Changes => new ChangesClient(_client);

	public ICollection Collection => new CollectionClient(_client);

	public ICompany Company => new CompanyClient(_client);

	public IConfiguration Configuration => new ConfigurationClient(_client);

	public ICredit Credit => new CreditClient(_client);

	public IDiscover Discover => new DiscoverClient(_client);

	public IFind Find => new FindClient(_client);

	public IGenre Genre => new GenreClient(_client);

	public IGuestSession GuestSession => new GuestSessionClient(_client);

	public IKeyword Keyword => new KeywordClient(_client);

	public IList List => new ListClient(_client);

	public IMovie Movie => new MovieClient(_client);

	public INetwork Network => new NetworkClient(_client);

	public IPerson Person => new PersonClient(_client);

	public IReview Review => new ReviewClient(_client);

	public ISearch Search => new SearchClient(_client);

	public ITrending Trending => new TrendingClient(_client);

	public ITvEpisode TvEpisode => new TvEpisodeClient(_client);

	public ITvEpisodeGroup TvEpisodeGroup => new TvEpisodeGroupClient(_client);

	public ITvSeason TvSeason => new TvSeasonClient(_client);

	public ITvSeries TvSeries => new TvSeriesClient(_client);

	public IWatchProviders WatchProviders => new WatchProvidersClient(_client);


}