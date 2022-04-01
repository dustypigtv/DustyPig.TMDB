namespace DustyPig.TMDB
{
    public static class Utils
    {
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
    }
}
