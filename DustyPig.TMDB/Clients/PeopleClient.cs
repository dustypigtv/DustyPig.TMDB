using DustyPig.REST;
using DustyPig.TMDB.Interfaces;
using DustyPig.TMDB.Models.Common;
using DustyPig.TMDB.Models.People;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Clients;

internal class PeopleClient : IPeople
{
    private readonly Client _client;

    internal PeopleClient(Client client) => _client = client;


    /// <summary>
    /// Get the recent changes for a person.
    /// </summary>
    public Task<Response<ChangeList>> GetChangesAsync(int personId, int page = 1, DateOnly? endDate = null, DateOnly? startDate = null, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "end_date", endDate.DateOnlyToTmdb() },
            { "start_date", startDate.DateOnlyToTmdb() }
        };

        return _client.GetAsync<ChangeList>($"/3/person/{personId}/changes", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get the combined movie and TV credits that belong to a person.
    /// </summary>
    public Task<Response<CombinedCredits>> GetCombinedCreditsAsync(string personId, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "language", language }
        };

        return _client.GetAsync<CombinedCredits>($"/3/person/{personId}/combined_credits", queryParams, cancellationToken);
    }

    /// <summary>
    /// Query the top level details of a person.
    /// </summary>
    /// <param name="appendToResponse">Info from endpoints in this namespace to add to the response. 20 values max.</param>
    public Task<Response<Details>> GetDetailsAsync(int personId, AppendToResponse? appendToResponse = null, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "append_to_response", appendToResponse?.GetEnumDescription() },
            { "language", language }
        };

        return _client.GetAsync<Details>($"/3/person/{personId}", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get the external ID&#39;s that belong to a person.
    /// </summary>
    public Task<Response<ExternalIds>> GetExternalIdsAsync(int personId, CancellationToken cancellationToken = default) =>
        _client.GetAsync<ExternalIds>($"/3/person/{personId}/external_ids", null, cancellationToken);

    /// <summary>
    /// Get the profile images that belong to a person.
    /// </summary>
    public Task<Response<Images>> GetImagesAsync(int personId, CancellationToken cancellationToken = default) =>
        _client.GetAsync<Images>($"/3/person/{personId}/images", null, cancellationToken);

    /// <summary>
    /// Get the newest created person. This is a live response and will continuously change.
    /// </summary>
    public Task<Response<Latest>> GetLatestAsync(CancellationToken cancellationToken = default) =>
        _client.GetAsync<Latest>("/3/person/latest", null, cancellationToken);

    /// <summary>
    /// Get the movie credits for a person.
    /// </summary>
    public Task<Response<MovieCredits>> GetMovieCreditsAsync(int personId, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "language", language }
        };

        return _client.GetAsync<MovieCredits>($"/3/person/{personId}/movie_credits", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get a list of people ordered by popularity.
    /// </summary>
    public Task<Response<PagedResult<Popular>>> GetPopularAsync(int page = 1, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "language", language }
        };

        return _client.GetAsync<PagedResult<Popular>>("/3/person/popular", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get the translations that belong to a person.
    /// </summary>
    public Task<Response<CommonTranslationList<CommonTranslationData>>> GetTranslationsAsync(int personId, CancellationToken cancellationToken = default) =>
        _client.GetAsync<CommonTranslationList<CommonTranslationData>>($"/3/person/{personId}/translations", null, cancellationToken);

    /// <summary>
    /// Get the TV credits that belong to a person.
    /// </summary>
    public Task<Response<TvSeriesCredits>> GetTvCreditsAsync(int personId, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "language", language }
        };

        return _client.GetAsync<TvSeriesCredits>($"/3/person/{personId}/tv_credits", queryParams, cancellationToken);
    }
}
