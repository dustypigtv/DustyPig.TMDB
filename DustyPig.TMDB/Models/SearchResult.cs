namespace DustyPig.TMDB.Models
{
    public class SearchResult
    {
        public int Id { get; set; }

        public string PosterPath { get; set; }

        public string BackdropPath { get; set; }

        public string ProfilePath { get; set; }

        public string Title { get; set; }

        public EntityTypes SearchResultType { get; set; }
    }
}
