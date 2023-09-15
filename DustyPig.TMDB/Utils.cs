namespace DustyPig.TMDB
{
    public static class Utils
    {
        // ***** Kept for backwards compatibility *****
        
        private const string IMAGE_BASE_LARGE = "https://image.tmdb.org/t/p/original";
        private const string IMAGE_BASE_SMALL = "https://image.tmdb.org/t/p/w185";

        public static string GetFullImagePath(string path, bool fullSize)
        {
            if (string.IsNullOrEmpty(path))
                return null;

            if (!path.StartsWith("/"))
                path = "/" + path;

            return fullSize ? IMAGE_BASE_LARGE + path : IMAGE_BASE_SMALL + path;
        }

        //*********************************************


        private const string ORIGINAL_BASE = "https://image.tmdb.org/t/p/original";
        private const string POSTER_BASE_SMALL = "https://image.tmdb.org/t/p/w185";
        private const string BACKDROP_BASE_SMALL = "https://image.tmdb.org/t/p/w300";

        public static string GetFullPosterPath(string path, bool fullSize)
        {
            if (string.IsNullOrEmpty(path))
                return null;

            if (!path.StartsWith("/"))
                path = "/" + path;

            return fullSize ? ORIGINAL_BASE + path : POSTER_BASE_SMALL + path;
        }

        public static string GetFullBackdropPath(string path, bool fullSize)
        {
            if (string.IsNullOrEmpty(path))
                return null;

            if (!path.StartsWith("/"))
                path = "/" + path;

            return fullSize ? ORIGINAL_BASE + path : BACKDROP_BASE_SMALL + path;
        }
    }
}
