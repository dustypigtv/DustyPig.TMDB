using DustyPig.TMDB;

namespace TestsProject;

static class ClientFactory
{
    private static readonly object _locker = new();
    private static Client _client = null;

    public static Client GetClient()
    {
        lock (_locker)
        {
            if (_client == null)
                _client = new(Client.AuthTypes.APIKey, Environment.GetEnvironmentVariable("TMDB_API_KEY"))
                {
                    RetryCount = 100,
                    RetryDelay = 250,
                    AutoThrowIfError = true,
                    IncludeRawContentInResponse = true
                };
        }
        return _client;
    }

}