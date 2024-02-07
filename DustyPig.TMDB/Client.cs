using DustyPig.REST;
using DustyPig.TMDB.Models;
using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB
{
    public class Client : IDisposable
    {
        private const string API_BASE_ADDRESS = "https://api.themoviedb.org/3/";

        private readonly REST.Client _client = new() { BaseAddress = new Uri(API_BASE_ADDRESS) };

        
        
        public Client() { }

        public Client(string apiKey) => APIKey = apiKey;

        public void Dispose()
        {
            _client.Dispose();
            GC.SuppressFinalize(this);
        }




        public bool IncludeRawContentInResponse
        {
            get => _client.IncludeRawContentInResponse;
            set => _client.IncludeRawContentInResponse = value;
        }

        public bool AutoThrowIfError
        {
            get => _client.AutoThrowIfError;
            set => _client.AutoThrowIfError = value;
        }

        
        public string APIKey { get; set; }


        private static string AddYearToMovieTitle(string title, DateTime? released)
        {
            if (released == null)
                return title;

            return title + $" ({released.Value.Year})";
        }

        private Task<Response<T>> GetAsync<T>(string url, CancellationToken cancellationToken)
        {
            string c = url.Contains('?') ? "&" : "?";
            url += c + "api_key=" + APIKey;
            return _client.GetAsync<T>(url, null, cancellationToken);
        }

        public async Task<Response<List<SearchResult>>> SearchAsync(string query, CancellationToken cancellationToken = default)
        {
            //This can return multiple pages, but in Dusty Pig only return the first page

            var response = await GetAsync<InternalSearchResults>($"search/multi?language=en-US&include_adult=false&query={WebUtility.UrlEncode(query)}", cancellationToken).ConfigureAwait(false);
            if (!response.Success)
                return new Response<List<SearchResult>>
                {
                    Error = response.Error,
                    RawContent = response.RawContent,
                    ReasonPhrase = response.ReasonPhrase,
                    StatusCode = response.StatusCode
                };

            response.Data ??= new InternalSearchResults();
            response.Data.Results ??= [];


            response.Data.Results.RemoveAll(item => !(new string[] { "movie", "tv" }.Contains(item.MediaType)));
            response.Data.Results.RemoveAll(item => item.MediaType == "movie" && string.IsNullOrWhiteSpace(item.Title));
            response.Data.Results.RemoveAll(item => item.MediaType == "tv" && string.IsNullOrWhiteSpace(item.Name));
            response.Data.Results.RemoveAll(item => string.IsNullOrWhiteSpace(item.PosterPath));

            var ret = new Response<List<SearchResult>>
            {
                Success = true,
                Data = [],
                RawContent = response.RawContent,
                ReasonPhrase = response.ReasonPhrase,
                StatusCode = response.StatusCode
            };

            foreach (var result in response.Data.Results)
            {
                var newItem = new SearchResult
                {
                    Id = result.Id,
                    IsMovie = result.MediaType == "movie",
                    PosterPath = result.PosterPath,
                    BackdropPath = result.BackdropPath,
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
                return new Response<List<SearchResult>>
                {
                    Error = response.Error,
                    RawContent = response.RawContent,
                    ReasonPhrase = response.ReasonPhrase,
                    StatusCode = response.StatusCode
                };

            response.Data ??= new InternalSearchResults();
            response.Data.Results ??= [];

            response.Data.Results.RemoveAll(item => string.IsNullOrWhiteSpace(item.Title));

            var ret = new Response<List<SearchResult>>
            {
                Success = true,
                Data = [],
                RawContent = response.RawContent,
                ReasonPhrase = response.ReasonPhrase,
                StatusCode = response.StatusCode
            };

            foreach (var result in response.Data.Results)
            {
                var newItem = new SearchResult
                {
                    Id = result.Id,
                    IsMovie = true,
                    PosterPath = result.PosterPath,
                    BackdropPath = result.BackdropPath,
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
                return new Response<List<SearchResult>>
                {
                    Error = response.Error,
                    RawContent = response.RawContent,
                    ReasonPhrase = response.ReasonPhrase,
                    StatusCode = response.StatusCode
                };

            response.Data ??= new InternalSearchResults();
            response.Data.Results ??= [];


            response.Data.Results.RemoveAll(item => string.IsNullOrWhiteSpace(item.Name));

            var ret = new Response<List<SearchResult>>
            {
                Success = true,
                Data = [],
                RawContent = response.RawContent,
                ReasonPhrase = response.ReasonPhrase,
                StatusCode = response.StatusCode
            };

            foreach (var result in response.Data.Results)
            {
                var newItem = new SearchResult
                {
                    Id = result.Id,
                    IsMovie = false,
                    PosterPath = result.PosterPath,
                    BackdropPath = result.BackdropPath,
                    Title = result.Name
                };

                ret.Data.Add(newItem);
            }

            return ret;
        }

        public Task<Response<Movie>> GetMovieAsync(int id, CancellationToken cancellationToken = default) =>
            GetAsync<Movie>($"movie/{id}?append_to_response=credits,releases", cancellationToken);



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
