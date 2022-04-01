using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Tests
{
    [TestClass]
    public class ClientTests
    {
        [TestMethod]
        public async Task Search()
        {
            using var client = ClientFactory.CreateClient();
            var ret = await client.SearchAsync("The Avengers").ConfigureAwait(false);
            ret.ThrowIfError();
        }

        [TestMethod]
        public async Task GetMovie()
        {
            using var client = ClientFactory.CreateClient();
            var ret = await client.GetMovieAsync(24428).ConfigureAwait(false);
            ret.ThrowIfError();
        }

        [TestMethod]
        public async Task GetMovieExternalIds()
        {
            using var client = ClientFactory.CreateClient();
            var ret = await client.GetMovieExternalIdsAsync(24428).ConfigureAwait(false);
            ret.ThrowIfError();
        }

        [TestMethod]
        public async Task GetSeries()
        {
            using var client = ClientFactory.CreateClient();
            var ret = await client.GetSeriesAsync(2473).ConfigureAwait(false);
            ret.ThrowIfError();
        }

        [TestMethod]
        public async Task GetSeriesExternalIds()
        {
            using var client = ClientFactory.CreateClient();
            var ret = await client.GetSeriesExternalIdsAsync(2437).ConfigureAwait(false);
            ret.ThrowIfError();
        }


        [TestMethod]
        public async Task GetEpisode()
        {
            using var client = ClientFactory.CreateClient();
            var ret = await client.GetEpisodeAsync(2473, 1, 1).ConfigureAwait(false);
            ret.ThrowIfError();
        }

        [TestMethod]
        public async Task GetEpisodeCredits()
        {
            using var client = ClientFactory.CreateClient();
            var ret = await client.GetEpisodeCreditsAsync(2473, 1, 1).ConfigureAwait(false);
            ret.ThrowIfError();
        }

        [TestMethod]
        public async Task GetEpisodeExternalIds()
        {
            using var client = ClientFactory.CreateClient();
            var ret = await client.GetEpisodeExternalIdsAsync(2473, 1, 1).ConfigureAwait(false);
            ret.ThrowIfError();
        }


    }
}
