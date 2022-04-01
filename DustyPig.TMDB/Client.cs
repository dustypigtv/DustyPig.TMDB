﻿using DustyPig.REST;
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
        private const string API_BASE_ADDRESS = "https://api.themoviedb.org/3";

        private static readonly REST.Client _client = new REST.Client();

        public Client() { }

        public Client(string apiKey) => APIKey = apiKey;


        public string APIKey { get; set; }


        private static string AddYearToMovieTitle(string title, DateTime? released)
        {
            if (released == null)
                return title;

            return title + $" ({released.Value.Year})";
        }

        public async Task<Response<List<SearchResult>>> SearchAsync(string query, CancellationToken cancellationToken = default)
        {
            //This can return multiple pages, but in Dusty Pig only return the first page

            var response = await _client.GetWithResponseDataAsync<InternalSearchResults>($"{API_BASE_ADDRESS}/search/multi?api_key={APIKey}&language=en-US&include_adult=false&query={WebUtility.UrlEncode(query)}", cancellationToken).ConfigureAwait(false);
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

        public async Task<Response<Movie>> GetMovieAsync(int id, CancellationToken cancellationToken = default)
        {
            var ret = await _client.GetWithResponseDataAsync<Movie>($"{API_BASE_ADDRESS}/movie/{id}?api_key={APIKey}&append_to_response=credits,releases", cancellationToken).ConfigureAwait(false);
            if (ret.Success)
                ret.Data.Title = AddYearToMovieTitle(ret.Data.Title, ret.Data.ReleaseDate);

            return ret;
        }


        public Task<Response<ExternalIds>> GetMovieExternalIdsAsync(int id, CancellationToken cancellationToken = default) =>
            _client.GetWithResponseDataAsync<ExternalIds>($"{API_BASE_ADDRESS}/movie/{id}/external_ids?api_key={APIKey}");



        public Task<Response<Series>> GetSeriesAsync(int id, CancellationToken cancellationToken = default) =>
            _client.GetWithResponseDataAsync<Series>($"{API_BASE_ADDRESS}/tv/{id}?api_key={APIKey}&append_to_response=credits,content_ratings", cancellationToken);


        public Task<Response<ExternalIds>> GetSeriesExternalIdsAsync(int id, CancellationToken cancellationToken = default) =>
            _client.GetWithResponseDataAsync<ExternalIds>($"{API_BASE_ADDRESS}/tv/{id}/external_ids?api_key={APIKey}");


        public Task<Response<Episode>> GetEpisodeAsync(int id, int season, int number, CancellationToken cancellationToken = default) =>
            _client.GetWithResponseDataAsync<Episode>($"{API_BASE_ADDRESS}/tv/{id}/season/{season}/episode/{number}?api_key={APIKey}");


        public Task<Response<Credits>> GetEpisodeCreditsAsync(int id, int season, int number, CancellationToken cancellationToken = default) =>
            _client.GetWithResponseDataAsync<Credits>($"{API_BASE_ADDRESS}/tv/{id}/season/{season}/episode/{number}/credits?api_key={APIKey}");


        public Task<Response<ExternalIds>> GetEpisodeExternalIdsAsync(int id, int season, int number, CancellationToken cancellationToken = default) =>
            _client.GetWithResponseDataAsync<ExternalIds>($"{API_BASE_ADDRESS}/tv/{id}/season/{season}/episode/{number}/external_ids?api_key={APIKey}");
    }
}
