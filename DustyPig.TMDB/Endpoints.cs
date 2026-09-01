using DustyPig.TMDB.Clients;

namespace DustyPig.TMDB;

public class Endpoints
{
    private readonly Client _client;

    internal Endpoints(Client client) => _client = client;

    public AccountClient Account => new(_client);

    public AuthenticationClient Authentication => new(_client);

    public CertificationsClient Certifications => new(_client);

    public ChangesClient Changes => new(_client);

    public CollectionsClient Collections => new(_client);

    public CompaniesClient Companies => new(_client);

    public ConfigurationClient Configuration => new(_client);

    public CreditsClient Credits => new(_client);

    public DiscoverClient Discover => new(_client);

    public FindClient Find => new(_client);

    public GenresClient Genres => new(_client);

    public GuestSessionsClient GuestSessions => new(_client);

    public KeywordsClient Keywords => new(_client);

    public ListsClient Lists => new(_client);

    public MovieListsClient MovieLists => new(_client);

    public MoviesClient Movies => new(_client);

    public NetworksClient Networks => new(_client);

    public PeopleListsClient PeopleLists => new(_client);

    public PeopleClient People => new(_client);

    public ReviewsClient Reviews => new(_client);

    public SearchClient Search => new(_client);

    public TrendingClient Trending => new(_client);

    public TvEpisodesClient TvEpisodes => new(_client);

    public TvEpisodeGroupsClient TvEpisodeGroups => new(_client);

    public TvSeasonsClient TvSeasons => new(_client);

    public TvSeriesListsClient TvSeriesLists => new(_client);

    public TvSeriesClient TvSeries => new(_client);

    public WatchProvidersClient WatchProviders => new(_client);
}