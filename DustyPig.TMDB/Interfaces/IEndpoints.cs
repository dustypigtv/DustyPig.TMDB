namespace DustyPig.TMDB.Interfaces;

public interface IEndpoints
{
    public IAccount Account { get; }

    public IAuthentication Authentication { get; }

    public ICertifications Certification { get; }

    public IChanges Changes { get; }

    public ICollections Collection { get; }

    public ICompanies Company { get; }

    public IConfiguration Configuration { get; }

    public ICredits Credit { get; }

    public IDiscover Discover { get; }

    public IFind Find { get; }

    public IGenres Genre { get; }

    public IGuestSessions GuestSession { get; }

    public IKeywords Keyword { get; }

    public ILists List { get; }

    public IMovies Movie { get; }

    public INetworks Network { get; }

    public IPeople Person { get; }

    public IReviews Review { get; }

    public ISearch Search { get; }

    public ITrending Trending { get; }

    public ITvEpisodes TvEpisode { get; }

    public ITvEpisodeGroups TvEpisodeGroup { get; }

    public ITvSeasons TvSeason { get; }

    public ITvSeries TvSeries { get; }

    public IWatchProviders WatchProviders { get; }


}
