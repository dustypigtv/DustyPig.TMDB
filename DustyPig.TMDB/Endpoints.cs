using DustyPig.TMDB.Clients;
using DustyPig.TMDB.Interfaces;

namespace DustyPig.TMDB;

internal class Endpoints : IEndpoints
{
    private readonly Client _client;

    internal Endpoints(Client client) => _client = client;

    public IAccount Account => new AccountClient(_client);

    public IAuthentication Authentication => new AuthenticationClient(_client);

    public ICertifications Certification => new CertificationsClient(_client);

    public IChanges Changes => new ChangesClient(_client);

    public ICollections Collection => new CollectionsClient(_client);

    public ICompanies Company => new CompaniesClient(_client);

    public IConfiguration Configuration => new ConfigurationClient(_client);

    public ICredits Credit => new CreditsClient(_client);

    public IDiscover Discover => new DiscoverClient(_client);

    public IFind Find => new FindClient(_client);

    public IGenres Genre => new GenresClient(_client);

    public IGuestSessions GuestSession => new GuestSessionsClient(_client);

    public IKeywords Keyword => new KeywordsClient(_client);

    public ILists List => new ListsClient(_client);

    public IMovies Movie => new MoviesClient(_client);

    public INetworks Network => new NetworksClient(_client);

    public IPeople Person => new PeopleClient(_client);

    public IReviews Review => new ReviewsClient(_client);

    public ISearch Search => new SearchClient(_client);

    public ITrending Trending => new TrendingClient(_client);

    public ITvEpisodes TvEpisode => new TvEpisodesClient(_client);

    public ITvEpisodeGroups TvEpisodeGroup => new TvEpisodeGroupsClient(_client);

    public ITvSeasons TvSeason => new TvSeasonsClient(_client);

    public ITvSeries TvSeries => new TvSeriesClient(_client);

    public IWatchProviders WatchProviders => new WatchProvidersClient(_client);


}