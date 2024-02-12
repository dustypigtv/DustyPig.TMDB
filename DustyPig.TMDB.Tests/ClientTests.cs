using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Tests
{
    [TestClass]
    public class ClientTests
    {
        private static readonly Client _client = ClientFactory.CreateClient();

        [TestMethod]
        public async Task Search()
        {
            var ret = await _client.SearchAsync("The Avengers").ConfigureAwait(false);
            ret.ThrowIfError();
        }

        [TestMethod]
        public async Task GetMovie()
        {
            var ret = await _client.GetMovieAsync(24428).ConfigureAwait(false);
            ret.ThrowIfError();
        }

        [TestMethod]
        public async Task GetMovieExternalIds()
        {
            var ret = await _client.GetMovieExternalIdsAsync(24428).ConfigureAwait(false);
            ret.ThrowIfError();
        }

        [TestMethod]
        public async Task GetSeries()
        {
            var ret = await _client.GetSeriesAsync(2473).ConfigureAwait(false);
            ret.ThrowIfError();
        }

        [TestMethod]
        public async Task GetSeriesExternalIds()
        {
            var ret = await _client.GetSeriesExternalIdsAsync(2437).ConfigureAwait(false);
            ret.ThrowIfError();
        }


        [TestMethod]
        public async Task GetEpisode()
        {
            var ret = await _client.GetEpisodeAsync(2473, 1, 1).ConfigureAwait(false);
            ret.ThrowIfError();
        }

        [TestMethod]
        public async Task GetEpisodeCredits()
        {
            var ret = await _client.GetEpisodeCreditsAsync(2473, 1, 1).ConfigureAwait(false);
            ret.ThrowIfError();
        }

        [TestMethod]
        public async Task GetEpisodeExternalIds()
        {
            var ret = await _client.GetEpisodeExternalIdsAsync(203, 4, 6).ConfigureAwait(false);
            ret.ThrowIfError();
        }

        [TestMethod]
        public async Task GetPerson()
        {
            var ret = await _client.GetPersonAsync(3).ConfigureAwait(false);
            ret.ThrowIfError();
        }
    }
}
