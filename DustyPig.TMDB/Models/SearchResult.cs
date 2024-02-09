namespace DustyPig.TMDB.Models
{
    public enum SearchResultTypes
    {
        Movie,
        Series,
        Person
    }

    public class SearchResult
    {
        public int Id { get; set; }

        public string PosterPath { get; set; }

        public string BackdropPath { get; set; }

        public string ProfilePath { get; set; }

        public string Title { get; set; }

        public SearchResultTypes SearchResultType { get; set; }
    }
}
