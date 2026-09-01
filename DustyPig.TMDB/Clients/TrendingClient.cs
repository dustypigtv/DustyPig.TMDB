using DustyPig.REST;
using DustyPig.TMDB.Enums;
using DustyPig.TMDB.Models.Common;
using DustyPig.TMDB.Models.Trending;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Clients;

public class TrendingClient
{
    private readonly Client _client;

    internal TrendingClient(Client client) => _client = client;


    /// <summary>
    /// Get the trending movies, TV shows and people.
    /// </summary>
    /// <param name="language">`ISO-639-1`-`ISO-3166-1` code</param>
    public async Task<Response<TrendingResponse>> GetAllAsync(Timewindow timeWindow = Timewindow.Day, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "language", language }
        };

        var response = await _client.GetAsync<PagedResult<JsonElement>>($"/3/trending/all/{timeWindow.GetEnumDescription()}", queryParams, cancellationToken).ConfigureAwait(false);

        var ret = new Response<TrendingResponse>
        {
            Error = response.Error,
            RawContent = response.RawContent,
            ReasonPhrase = response.ReasonPhrase,
            StatusCode = response.StatusCode,
            Success = response.Success,
        };

        if (response.Data != null)
        {
            ret.Data = new TrendingResponse()
            {
                AdditionalProperties = response.Data.AdditionalProperties ?? [],
                Page = response.Data.Page,
                TotalPages = response.Data.TotalPages,
                TotalResults = response.Data.TotalResults
            };

            foreach (var item in response.Data.Results ?? [])
            {
                if (item.TryGetProperty("media_type", out var mediaTypeProp))
                {
                    var mediaType = mediaTypeProp.GetString();
                    switch (mediaType)
                    {
                        case "movie":
                            ret.Data.Movies.Add(item.Deserialize<Movie>());
                            break;
                        case "tv":
                            ret.Data.Series.Add(item.Deserialize<TvSeries>());
                            break;
                        case "person":
                            ret.Data.People.Add(item.Deserialize<Person>());
                            break;
                    }
                }
            }
        }

        return ret;
    }

    /// <summary>
    /// Get the trending movies on TMDB.
    /// </summary>
    /// <param name="language">`ISO-639-1`-`ISO-3166-1` code</param>
    public Task<Response<PagedResult<Movie>>> GetMoviesAsync(Timewindow timeWindow = Timewindow.Day, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "language", language }
        };

        return _client.GetAsync<PagedResult<Movie>>($"/3/trending/movie/{timeWindow.GetEnumDescription()}", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get the trending people on TMDB.
    /// </summary>
    /// <param name="language">`ISO-639-1`-`ISO-3166-1` code</param>
    public Task<Response<PagedResult<Person>>> GetPeopleAsync(Timewindow timeWindow = Timewindow.Day, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "language", language }
        };

        return _client.GetAsync<PagedResult<Person>>($"/3/trending/person/{timeWindow.GetEnumDescription()}", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get the trending TV shows on TMDB.
    /// </summary>
    /// <param name="language">`ISO-639-1`-`ISO-3166-1` code</param>
    public Task<Response<PagedResult<TvSeries>>> GetTvSeriesAsync(Timewindow timeWindow = Timewindow.Day, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "language", language }
        };

        return _client.GetAsync<PagedResult<TvSeries>>($"/3/trending/tv/{timeWindow.GetEnumDescription()}", queryParams, cancellationToken);
    }
}
