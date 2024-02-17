namespace DustyPig.TMDB.Interfaces;

public interface IEndpoints
{
	public IAccount Account { get; }

	public IAuthentication Authentication { get; }

	public ICertification Certification { get; }

	public IChanges Changes { get; }

	public ICollection Collection { get; }

	public ICompany Company { get; }

	public IConfiguration Configuration { get; }

	public ICredit Credit { get; }

	public IDiscover Discover { get; }

	public IFind Find { get; }

	public IGenre Genre { get; }

	public IGuestSession GuestSession { get; }

	public IKeyword Keyword { get; }

	public IList List { get; }

	public IMovie Movie { get; }

	public INetwork Network { get; }

	public IPerson Person { get; }

	public IReview Review { get; }

	public ISearch Search { get; }

	public ITrending Trending { get; }

	public ITvEpisode TvEpisode { get; }

	public ITvEpisodeGroup TvEpisodeGroup { get; }

	public ITvSeason TvSeason { get; }

	public ITvSeries TvSeries { get; }

	public IWatchProviders WatchProviders { get; }


}
