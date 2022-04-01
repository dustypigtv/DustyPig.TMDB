namespace DustyPig.TMDB.Models
{
    public class SearchResult
    {
        public int Id { get; set; }

        public string PosterPath { get; set; }

        public string Title { get; set; }

        public bool IsMovie { get; set; }
    }
}
