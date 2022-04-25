using DustyPig.REST;
using DustyPig.TMDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB
{
    public class Client
    {
        private const string API_BASE_ADDRESS = "https://api.themoviedb.org/3/";

        private static readonly REST.Client _client = new REST.Client() { BaseAddress = new Uri(API_BASE_ADDRESS) };

        public Client() { }

        public Client(string apiKey) => APIKey = apiKey;


        public string APIKey { get; set; }


        private static string AddYearToMovieTitle(string title, DateTime? released)
        {
            if (released == null)
                return title;

            return title + $" ({released.Value.Year})";
        }

        private Task<Response<T>> GetAsync<T>(string url, CancellationToken cancellationToken)
        {
            string c = url.Contains("?") ? "&" : "?";
            url += c + "api_key=" + APIKey;
            return _client.GetAsync<T>(url, null, null, cancellationToken);
        }

        public async Task<Response<List<SearchResult>>> SearchAsync(string query, CancellationToken cancellationToken = default)
        {
            //This can return multiple pages, but in Dusty Pig only return the first page

            var response = await GetAsync<InternalSearchResults>($"search/multi?language=en-US&include_adult=false&query={WebUtility.UrlEncode(query)}", cancellationToken).ConfigureAwait(false);
            if (!response.Success)
                return new Response<List<SearchResult>> { Error = response.Error };

            if (response.Data == null)
                response.Data = new InternalSearchResults();

            if (response.Data.Results == null)
                response.Data.Results = new List<InternalSearchResult>();


            response.Data.Results.RemoveAll(item => !(new string[] { "movie", "tv" }.Contains(item.MediaType)));
            response.Data.Results.RemoveAll(item => item.MediaType == "movie" && string.IsNullOrWhiteSpace(item.Title));
            response.Data.Results.RemoveAll(item => item.MediaType == "tv" && string.IsNullOrWhiteSpace(item.Name));
            response.Data.Results.RemoveAll(item => string.IsNullOrWhiteSpace(item.PosterPath));

            var ret = new Response<List<SearchResult>> { Success = true, Data = new List<SearchResult>() };

            foreach (var result in response.Data.Results)
            {
                var newItem = new SearchResult
                {
                    Id = result.Id,
                    IsMovie = result.MediaType == "movie",
                    PosterPath = result.PosterPath,
                    Title = result.MediaType == "movie" ? result.Title : result.Name
                };

                if (newItem.IsMovie)
                    newItem.Title = AddYearToMovieTitle(newItem.Title, result.ReleaseDate);

                ret.Data.Add(newItem);
            }

            return ret;
        }


        public async Task<Response<List<SearchResult>>> SearchMoviesAsync(string query, int year = 0, CancellationToken cancellationToken = default)
        {
            //This can return multiple pages, but in Dusty Pig only return the first page

            string url = "search/movie?language=en-US&include_adult=false";
            if (year > 0)
                url += $"&year={year}";

            var response = await GetAsync<InternalSearchResults>($"{url}&query={WebUtility.UrlEncode(query)}", cancellationToken).ConfigureAwait(false);
            if (!response.Success)
                return new Response<List<SearchResult>> { Error = response.Error };

            if (response.Data == null)
                response.Data = new InternalSearchResults();

            if (response.Data.Results == null)
                response.Data.Results = new List<InternalSearchResult>();


            response.Data.Results.RemoveAll(item => string.IsNullOrWhiteSpace(item.Title));

            var ret = new Response<List<SearchResult>> { Success = true, Data = new List<SearchResult>() };

            foreach (var result in response.Data.Results)
            {
                var newItem = new SearchResult
                {
                    Id = result.Id,
                    IsMovie = true,
                    PosterPath = result.PosterPath,
                    Title = AddYearToMovieTitle(result.Title, result.ReleaseDate)
                };
 
                ret.Data.Add(newItem);
            }

            return ret;
        }


        public async Task<Response<List<SearchResult>>> SearchSeriesAsync(string query, int year = 0, CancellationToken cancellationToken = default)
        {
            //This can return multiple pages, but in Dusty Pig only return the first page

            string url = "search/tv?language=en-US&include_adult=false";
            if (year > 0)
                url += $"&first_air_date_year={year}";

            var response = await GetAsync<InternalSearchResults>($"{url}&query={WebUtility.UrlEncode(query)}", cancellationToken).ConfigureAwait(false);
            if (!response.Success)
                return new Response<List<SearchResult>> { Error = response.Error };

            if (response.Data == null)
                response.Data = new InternalSearchResults();

            if (response.Data.Results == null)
                response.Data.Results = new List<InternalSearchResult>();


            response.Data.Results.RemoveAll(item => string.IsNullOrWhiteSpace(item.Name));

            var ret = new Response<List<SearchResult>> { Success = true, Data = new List<SearchResult>() };

            foreach (var result in response.Data.Results)
            {
                var newItem = new SearchResult
                {
                    Id = result.Id,
                    IsMovie = false,
                    PosterPath = result.PosterPath,
                    Title = result.Name
                };

                ret.Data.Add(newItem);
            }

            return ret;
        }

        public async Task<Response<Movie>> GetMovieAsync(int id, CancellationToken cancellationToken = default)
        {
            var ret = await GetAsync<Movie>($"movie/{id}?append_to_response=credits,releases", cancellationToken).ConfigureAwait(false);
            if (ret.Success)
                ret.Data.Title = AddYearToMovieTitle(ret.Data.Title, ret.Data.ReleaseDate);

            return ret;
        }


        public Task<Response<ExternalIds>> GetMovieExternalIdsAsync(int id, CancellationToken cancellationToken = default) =>
            GetAsync<ExternalIds>($"movie/{id}/external_ids", cancellationToken);



        public Task<Response<Series>> GetSeriesAsync(int id, CancellationToken cancellationToken = default) =>
            GetAsync<Series>($"tv/{id}?append_to_response=credits,content_ratings", cancellationToken);


        public Task<Response<ExternalIds>> GetSeriesExternalIdsAsync(int id, CancellationToken cancellationToken = default) =>
            GetAsync<ExternalIds>($"tv/{id}/external_ids", cancellationToken);


        public Task<Response<Episode>> GetEpisodeAsync(int id, int season, int number, CancellationToken cancellationToken = default) =>
            GetAsync<Episode>($"tv/{id}/season/{season}/episode/{number}", cancellationToken);


        public Task<Response<Credits>> GetEpisodeCreditsAsync(int id, int season, int number, CancellationToken cancellationToken = default) =>
            GetAsync<Credits>($"tv/{id}/season/{season}/episode/{number}/credits", cancellationToken);


        public Task<Response<ExternalIds>> GetEpisodeExternalIdsAsync(int id, int season, int number, CancellationToken cancellationToken = default) =>
            GetAsync<ExternalIds>($"tv/{id}/season/{season}/episode/{number}/external_ids", cancellationToken);
    }
}
