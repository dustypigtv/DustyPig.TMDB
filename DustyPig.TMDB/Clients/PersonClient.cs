using DustyPig.REST;
using DustyPig.TMDB.Interfaces;
using DustyPig.TMDB.Models.Common;
using DustyPig.TMDB.Models.Person;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DustyPig.TMDB.Clients;

internal class PersonClient : IPerson
{
    private readonly Client _client;

    internal PersonClient(Client client) => _client = client;


    /// <summary>
    /// Get the recent changes for a person.
    /// </summary>
    public Task<Response<ChangesResponse>> GetChangesAsync(int personId, int page = 1, DateOnly? endDate = null, DateOnly? startDate = null, CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "end_date", endDate.DateOnlyToTmdb() },
            { "start_date", startDate.DateOnlyToTmdb() }
        };

        return _client.GetAsync<ChangesResponse>($"/3/person/{personId}/changes", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get the combined movie and TV credits that belong to a person.
    /// </summary>
    public Task<Response<CombinedCreditsResponse>> GetCombinedCreditsAsync(string personId, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "language", language }
        };

        return _client.GetAsync<CombinedCreditsResponse>($"/3/person/{personId}/combined_credits", queryParams, cancellationToken);
    }

    /// <summary>
    /// Query the top level details of a person.
    /// </summary>
    /// <param name="appendToResponse">Info from endpoints in this namespace to add to the response. 20 values max.</param>
    public Task<Response<DetailsResponse>> GetDetailsAsync(int personId, AppendToResponse? appendToResponse = null, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "append_to_response", appendToResponse?.GetEnumDescription() },
            { "language", language }
        };

        return _client.GetAsync<DetailsResponse>($"/3/person/{personId}", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get the external ID&#39;s that belong to a person.
    /// </summary>
    public Task<Response<ExternalIdsResponse>> GetExternalIdsAsync(int personId, CancellationToken cancellationToken = default) =>
        _client.GetAsync<ExternalIdsResponse>($"/3/person/{personId}/external_ids", null, cancellationToken);

    /// <summary>
    /// Get the profile images that belong to a person.
    /// </summary>
    public Task<Response<ImagesResponse>> GetImagesAsync(int personId, CancellationToken cancellationToken = default) =>
        _client.GetAsync<ImagesResponse>($"/3/person/{personId}/images", null, cancellationToken);

    /// <summary>
    /// Get the newest created person. This is a live response and will continuously change.
    /// </summary>
    public Task<Response<LatestResponse>> GetLatestAsync(CancellationToken cancellationToken = default) =>
        _client.GetAsync<LatestResponse>("/3/person/latest", null, cancellationToken);

    /// <summary>
    /// Get the movie credits for a person.
    /// </summary>
    public Task<Response<MovieCreditsResponse>> GetMovieCreditsAsync(int personId, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "language", language }
        };

        return _client.GetAsync<MovieCreditsResponse>($"/3/person/{personId}/movie_credits", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get a list of people ordered by popularity.
    /// </summary>
    public Task<Response<PagedResult<PopularResponse>>> GetPopularAsync(int page = 1, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "page", page },
            { "language", language }
        };

        return _client.GetAsync<PagedResult<PopularResponse>>("/3/person/popular", queryParams, cancellationToken);
    }

    /// <summary>
    /// Get the translations that belong to a person.
    /// </summary>
    public Task<Response<CommonTranslations<CommonTranslation>>> GetTranslationsAsync(int personId, CancellationToken cancellationToken = default) =>
        _client.GetAsync<CommonTranslations<CommonTranslation>>($"/3/person/{personId}/translations", null, cancellationToken);

    /// <summary>
    /// Get the TV credits that belong to a person.
    /// </summary>
    public Task<Response<TvCreditsResponse>> GetTvCreditsAsync(int personId, string language = "en-US", CancellationToken cancellationToken = default)
    {
        var queryParams = new Dictionary<string, object>
        {
            { "language", language }
        };

        return _client.GetAsync<TvCreditsResponse>($"/3/person/{personId}/tv_credits", queryParams, cancellationToken);
    }
}
