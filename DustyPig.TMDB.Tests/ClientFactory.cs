using System;

namespace DustyPig.TMDB.Tests
{
    static class ClientFactory
    {
        const string ENV_VARIABLE = "TMDB_API_KEY";

        private static string GetKey()
        {
            string key = Environment.GetEnvironmentVariable(ENV_VARIABLE, EnvironmentVariableTarget.Process);

            if (string.IsNullOrWhiteSpace(key))
                key = Environment.GetEnvironmentVariable(ENV_VARIABLE, EnvironmentVariableTarget.User);

            if (string.IsNullOrWhiteSpace(key))
                key = Environment.GetEnvironmentVariable(ENV_VARIABLE, EnvironmentVariableTarget.Machine);

            return key;
        }

        public static Client CreateClient()
        {
            return new Client(GetKey())
            {
                IncludeRawContentInResponse = true,
                AutoThrowIfError = false
            };
        }
    }
}
