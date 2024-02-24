using DustyPig.TMDB.Clients;
using DustyPig.TMDB.Interfaces;

namespace DustyPig.TMDB;

internal class Endpoints : IEndpoints
{
    private readonly Client _client;

    internal Endpoints(Client client) => _client = client;

    public IAccount Account => new AccountClient(_client);

    public IAuthentication Authentication => new AuthenticationClient(_client);

    public ICertifications Certifications => new CertificationsClient(_client);

    public IChanges Changes => new ChangesClient(_client);

    public ICollections Collections => new CollectionsClient(_client);

    public ICompanies Companies => new CompaniesClient(_client);

    public IConfiguration Configuration => new ConfigurationClient(_client);

    public ICredits Credits => new CreditsClient(_client);

    public IDiscover Discover => new DiscoverClient(_client);

    public IFind Find => new FindClient(_client);

    public IGenres Genres => new GenresClient(_client);

    public IGuestSessions GuestSessions => new GuestSessionsClient(_client);

    public IKeywords Keywords => new KeywordsClient(_client);

    public ILists Lists => new ListsClient(_client);

    public IMovieLists MovieLists => new MovieListsClient(_client);

    public IMovies Movies => new MoviesClient(_client);

    public INetworks Networks => new NetworksClient(_client);

    public IPeopleLists PeopleLists => new PeopleListsClient(_client);

    public IPeople People => new PeopleClient(_client);

    public IReviews Reviews => new ReviewsClient(_client);

    public ISearch Search => new SearchClient(_client);

    public ITrending Trending => new TrendingClient(_client);

    public ITvEpisodes TvEpisodes => new TvEpisodesClient(_client);

    public ITvEpisodeGroups TvEpisodeGroups => new TvEpisodeGroupsClient(_client);

    public ITvSeasons TvSeasons => new TvSeasonsClient(_client);

    public ITvSeriesLists TvSeriesLists => new TvSeriesListsClient(_client);

    public ITvSeries TvSeries => new TvSeriesClient(_client);

    public IWatchProviders WatchProviders => new WatchProvidersClient(_client);


}