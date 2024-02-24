namespace DustyPig.TMDB.Interfaces;

public interface IEndpoints
{
    public IAccount Account { get; }

    public IAuthentication Authentication { get; }

    public ICertifications Certifications { get; }

    public IChanges Changes { get; }

    public ICollections Collections { get; }

    public ICompanies Companies { get; }

    public IConfiguration Configuration { get; }

    public ICredits Credits { get; }

    public IDiscover Discover { get; }

    public IFind Find { get; }

    public IGenres Genres { get; }

    public IGuestSessions GuestSessions { get; }

    public IKeywords Keywords { get; }

    public ILists Lists { get; }

    public IMovieLists MovieLists { get; }

    public IMovies Movies { get; }

    public INetworks Networks { get; }

    public IPeopleLists PeopleLists { get; }

    public IPeople People { get; }

    public IReviews Reviews { get; }

    public ISearch Search { get; }

    public ITrending Trending { get; }

    public ITvEpisodes TvEpisodes { get; }

    public ITvEpisodeGroups TvEpisodeGroups { get; }

    public ITvSeasons TvSeasons { get; }

    public ITvSeriesLists TvSeriesLists { get; }

    public ITvSeries TvSeries { get; }

    public IWatchProviders WatchProviders { get; }


}
